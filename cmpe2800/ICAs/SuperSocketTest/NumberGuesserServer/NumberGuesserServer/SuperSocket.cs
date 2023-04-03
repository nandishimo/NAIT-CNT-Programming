using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using Newtonsoft.Json;

namespace NumberGuesserServer
{
    public class SuperSocket
    {
        /*
         * - a connected socket
         * - a delegate for errors
         * - a delegate for data 
         * - a thread 
         * 
         */

        private Socket sokConnect; //connected socket

        public delegate void errorHandler(Exception ex); //send errors back to the user
        private errorHandler errors;
        public delegate void dataSender(string json); //send recieved data back to the user
        private dataSender data;

        private Thread rxLoop; //actual loop
        private Thread returnLoop; //loop to send data to user
        private Thread txLoop; //loop to send data out through the socket

        //stats keeping
        public int bytesRecieved;
        public int framesRecived;
        public int fragmentsRecieved;

        //strings
        private string fragment;

        //queues
        private Queue<string> toReturn;
        private Queue<string> toSend;

        //buffer size
        private int bufferSize;

        public SuperSocket(Socket connectedSocket, errorHandler ErrorHandler, dataSender DataSender, int bufferSize = 2048)
        {
            if (connectedSocket == null || ErrorHandler == null || DataSender == null) return; //nah

            sokConnect = connectedSocket;
            errors = ErrorHandler;
            data = DataSender;

            //setup queues
            toReturn = new Queue<string>();
            toSend = new Queue<string>();

            //set fragment string
            fragment = "";

            //set up stats
            bytesRecieved = 0;
            framesRecived = 0;
            fragmentsRecieved = 0;
            this.bufferSize = bufferSize;


            //now spin up the data reciever and all that
            rxLoop = new Thread(RX);
            rxLoop.IsBackground = true;
            rxLoop.Start();

            //also start up the return loop
            returnLoop = new Thread(returner);
            returnLoop.IsBackground = true;
            returnLoop.Start();

            //and the send loop
            txLoop = new Thread(TX);
            txLoop.IsBackground = true;
            txLoop.Start();
        }

        /// <summary>
        /// recieve and decode data into json string packets
        /// </summary>
        private void RX()
        {
             while(true)
             {
                byte[] buff = new byte[bufferSize];
                try
                {
                    int numBytesRecieved = sokConnect.Receive(buff);

                    if(numBytesRecieved == 0)
                    {
                        //user hung up after saying goodbye

                        //close socket
                        try
                        {
                            //tell the user things have gone wrong
                            errors(new Exception("User disconnected, exiting"));
                        }
                        catch(Exception ex)
                        {
                            errors(ex);
                        }
                        
                        return;
                    }

                    bytesRecieved += numBytesRecieved;

                    //data has been recieved ! 
                    //time to process data 
                    //decode the data
                    try
                    {
                        string temp = Encoding.UTF8.GetString(buff);
                        temp = temp.Trim((char)0x0);

                        decode(temp);

                    }
                    catch(Exception ex)
                    {
                        errors(ex);
                    }
                }
                catch(Exception err)
                {
                    //EVERYTHING EXPLODED
                    //User just disconnected rudely
                    //how rude
                    try
                    {
                        //tell the user things have gone wrong
                        errors(new Exception("User disconnected, Rudely, exiting"));
                    }
                    catch (Exception ex)
                    {
                        errors(ex);
                    }

                    return;
                }
             }
        }

        
        /// <summary>
        /// Process and enqueue json strings
        /// </summary>
        /// <param name="json"></param>
        private void decode(string json)
        {
            //take json
            //count frames
            //queue whole frames (with lock)
            //save fragment
            if (json == null || json == "" 
                || (fragment.Length == 0 && !json.Contains('{')))
                return;

            int chickenLips = 0;
            string process = fragment + json;


            for(int i = 0; i<process.Length; i++)
            {
                //{hello}
                if (process[i] == '{')
                    chickenLips++;
                else if (process[i] == '}')
                    chickenLips--;

                if(chickenLips == 0)
                {
                    //full frame, queue it up
                    lock(toReturn)
                    {
                        toReturn.Enqueue(process.Substring(0,i+1)); //enqueue the frame
                    }

                    process = process.Remove(0,i+1); //remove the frame
                    i = 0;

                    framesRecived++;
                    fragment = "";
                }
            }

            if(process.Length > 0)
            {
                fragment = process;
                fragmentsRecieved++;
            }

        }

        /// <summary>
        /// None blocking return function
        /// </summary>
        private void returner()
        {
            Queue<string> temp;

            while (true)
            { 
                if(toReturn.Count > 0) //only send data if there is data
                {
                    //copy the senders
                    lock(toReturn)
                    {
                        temp = new Queue<string>(toReturn);
                        toReturn.Clear();
                    }

                    for(int i = 0; i<temp.Count(); i++)
                    {
                        data(temp.Dequeue());
                    }

                    temp.Clear();
                }

                Thread.Sleep(100);//sleep until new data
            }
            
        }

        /// <summary>
        /// Queue up data to send
        /// </summary>
        /// <param name="data"></param>
        public void Send(string data)
        {
            //send the data
            lock(toSend)
            {
                toSend.Enqueue(data);
            }
            
        }
        
        /// <summary>
        /// Now with none blocking send code!
        /// </summary>
        public void TX()
        {
            while(true)
            {
                Queue<string> temp;

                if(toSend.Count > 0)
                {
                    //copy sending
                    lock(toSend)
                    {
                        temp = new Queue<string>(toSend);
                        toSend.Clear(); //clear. ready to get new data
                    }

                    for (int i = 0; i < temp.Count(); i++)
                    {
                        sokConnect.Send(Encoding.UTF8.GetBytes(temp.Dequeue())); //dequeue data
                    }
                }


                Thread.Sleep(100);
            }
        }

        /// <summary>
        /// Kill the socket
        /// </summary>
        public void Close()
        {
            sokConnect.Shutdown(SocketShutdown.Both);
            sokConnect.Close();
        }


    }
}
