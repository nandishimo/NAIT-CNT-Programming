using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogTest;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using Newtonsoft.Json;

namespace NumberGuesserServer
{
    public partial class SERVER : Form
    {
        //Sockets and thread inits
        private Socket Listener = null;
        private Socket Connect = null;

        private SuperSocket SuperSocket = null;

        private Thread dataRX = null; //recieving data sucks

        private int port = 1666;
        private Logger log = new Logger($"SERVER_LOG.txt");

        private int secretNum;
        const int max = 1000;
        private static Random rnd = new Random();

        public SERVER()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Once the server has loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SERVER_Load(object sender, EventArgs e)
        {
            log.Write($"Server: Form loaded");
            listenerUp(ref Listener);
            log.Write($"Server: Listening");

        }

        /// <summary>
        /// Listener callback
        /// </summary>
        /// <param name="ar"></param>
        private void CALLBACK_Accept(IAsyncResult ar)
        {
            //Now we try to connect, and tear down the listener if we do

            try 
            {
                Connect = Listener.EndAccept(ar);

                //likely mention its connected
                log.Write("Connected to client");

                try
                {
                    Invoke(new Action(() => Text = "Client Connected!"));
                }
                catch (Exception e)
                {
                    log.Write($"Unable to update UI! {e.Message}");
                }
                

                Listener.Close();

                SuperSocket = new SuperSocket(Connect, errorHandling, dataReceving);

                /*//start thread
                log.Write("Starting Thread");

                dataRX = new Thread(NumberReceiving); 
                dataRX.IsBackground = true;
                dataRX.Start();*/


            }
            catch (Exception ex)
            {
                log.Write($"Unable to accept connection: {ex.Message}");

                try
                {
                    Invoke(new Action(() => Text = "SERVER LISTENING"));
                }
                catch (Exception e)
                {
                    log.Write($"Unable to update UI! {e.Message}");
                }

            }
        }

        private void errorHandling(Exception ex)
        {
            if (ex == null)
                return;

            log.Write($"Connection has ended: encountered error: {ex.Message}");

            try
            {
                Invoke(new Action(() => Text = "Disconnected"));
            }
            catch (Exception e)
            {
                log.Write($"Unable to update UI! {e.Message}");
            }
            

            SuperSocket.Close();
            listenerUp(ref Listener);

        }

        private void dataReceving(string json)
        {
            GGData data;
            int send;

            //log some data
            log.Write($"Bytes Recieved so far: {SuperSocket.bytesRecieved}");
            log.Write($"Complete frames: {SuperSocket.framesRecived} ");
            log.Write($"Fragments: {SuperSocket.fragmentsRecieved}");


            try
            {

                log.Write($"Json recieved: {json}");

                //turn into json, if this all works we should have usable data
                data = JsonConvert.DeserializeObject<GGData>(json);

            }
            catch (Exception err)
            {
                log.Write($"Unable to decode into a usable value: {err.Message}");
                return;
            }

            try
            {
                //compare the secret number
                if (data == null)
                {
                    return;
                }

                try
                {
                    Invoke(new Action(() => Text = $"Client Guessed: {data.Num}"));
                }
                catch (Exception ex)
                {
                    log.Write($"Unable to update UI! {ex.Message}");
                }


                send = data.Num.CompareTo(secretNum);
                log.Write($"Compared data to secretNum and got {send}");
                if (send == 0)
                {
                    secretNum = rnd.Next(1, max);
                    log.Write($"new secret number is: {secretNum}");
                    try
                    {
                        Invoke(new Action(() => { Text = "Client Guessed Number, Generating New Number"; lblNum.Text = secretNum.ToString(); }));
                    }
                    catch (Exception ex)
                    {
                        log.Write($"Unable to update UI! {ex.Message}");
                    }

                }

                //prepare it into a json
                json = JsonConvert.SerializeObject(new GGData(send));
                log.Write($"Json sending: {json}");

                //send it back
                SuperSocket.Send(json);
            }
            catch (Exception ex)
            {
                log.Write($"Server: unable to send data! {ex.Message}");
                return;
            }


        }

        /// <summary>
        /// the actual number guessing part
        /// </summary>
       /* private void NumberReceiving()
        {
            
            log.Write("Thread Started");
            
            string json;
            GGData data;
            int send;

            while(true)
            {
                byte[] buff = new byte[2048];
                try
                {
                    int numBytesRecieved = Connect.Receive(buff);

                    if(numBytesRecieved == 0)
                    {
                        //user hung up after saying goodbye
                        log.Write($"Connection has ended: User Disconnected (Soft disco ^.\\=/.^)");

                        //restart listener
                        listenerUp(ref Listener);
                        log.Write($"Server: Listening");


                        try
                        {
                            Invoke(new Action(() => Text = "Client Disco"));
                        }
                        catch (Exception ex)
                        {
                            log.Write($"Unable to update UI! {ex.Message}");
                        }
                        
                        return;
                    }

                    //data has been recieved ! 
                    //now turn into json, check the value, and send back a json 
                    log.Write($"Recieved data from client");
                    try
                    {
                        //assuming no bells or whistles, it should just encode
                        json = Encoding.UTF8.GetString(buff);

                        log.Write($"Json recieved: {json}");

                        //turn into json, if this all works we should have usable data
                        data = JsonConvert.DeserializeObject<GGData>(json);


                    }
                    catch (Exception err)
                    {
                        log.Write($"Unable to decode into a usable value: {err.Message}");
                        continue;
                    }


                    try
                    {
                        //compare the secret number
                        if (data == null)
                        {
                            continue;
                        }

                        try
                        {
                            Invoke(new Action(() => Text = $"Client Guessed: {data.Num}"));
                        }
                        catch(Exception ex)
                        {
                            log.Write($"Unable to update UI! {ex.Message}");
                        }


                        send = data.Num.CompareTo(secretNum);
                        log.Write($"Compared data to secretNum and got {send}");
                        if (send == 0)
                        {
                            secretNum = rnd.Next(1, max);
                            log.Write($"new secret number is: {secretNum}");
                            try
                            {
                                Invoke(new Action(() => { Text = "Client Guessed Number, Generating New Number"; lblNum.Text = secretNum.ToString(); }));
                            }
                            catch (Exception ex)
                            {
                                log.Write($"Unable to update UI! {ex.Message}");
                            }
                            
                        }

                        //prepare it into a json
                        json = JsonConvert.SerializeObject(new GGData(send));
                        log.Write($"Json sending: {json}");

                        //send it back
                        Connect.Send(Encoding.UTF8.GetBytes(json));
                    }
                    catch (Exception ex)
                    {
                        log.Write($"Server: unable to send data! {ex.Message}");
                        continue;
                    }


                }
                catch(Exception err)
                {
                    //EVERYTHING EXPLODED
                    log.Write($"Connection has ended: {err.Message}");

                    try
                    {
                        Invoke(new Action(() => Text = "Client Disco"));
                    }
                    catch (Exception ex)
                    {
                        log.Write($"Unable to update UI! {ex.Message}");
                    }
                    
                    //restart listener
                    listenerUp(ref Listener);
                    log.Write($"Server: Listening");

                    return;
                }
            }
        }*/

        public void listenerUp(ref Socket s)
        {
            s = new Socket(
                AddressFamily.InterNetwork, // IP V4 address scheme
                SocketType.Stream, // streaming socket (connection based)
                ProtocolType.Tcp); // use TCP as protocol //thanks demo

            secretNum = rnd.Next(1, max);
            
            try
            {
                Invoke(new Action(() => lblNum.Text = secretNum.ToString()));
            }
            catch(Exception ex)
            {
                log.Write($"Server: unable to update UI {ex.Message}");
            }

            
            try
            {
                //binding
                s.Bind(new IPEndPoint(IPAddress.Any, port));
            }
            catch (Exception ex)
            {
                log.Write($"Server: Unable to bind, something else is already bound! {ex.Message}");
                
                try
                {
                    Invoke(new Action(() => Text = "Unable to start Server"));
                }
                catch (Exception e)
                {
                    log.Write($"Unable to update UI! {e.Message}");
                }
            }

            try
            {
                s.Listen(5);
            }
            catch (Exception ex)
            {
                log.Write($"Server: Unable to listen! {ex.Message}");
            }

            try
            {
                s.BeginAccept(CALLBACK_Accept, null);
                log.Write("Listening");
            }
            catch (Exception ex)
            {
                log.Write($"Unable to start accepting: {ex.Message}");
            }
            
        }

        /// <summary>
        /// Send bad json data disguised as correct json
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWrong_Click(object sender, EventArgs e)
        {
            byte[] buff = new byte[2048];
            string json;

            if (Connect == null)
                return;

            try
            {
                if(!Connect.Connected)
                    return;

                //prepare it into a json
                json = JsonConvert.SerializeObject(new Fakeie("HAHAHHAA SUCKS"));
                log.Write($"Json sending: {json}");

                //send it back
                Connect.Send(Encoding.UTF8.GetBytes(json));


            }
            catch (Exception err)
            {
                log.Write($"Sent wrong {err.Message}");
            }
        }

        /// <summary>
        /// send an empty json 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmpty_Click(object sender, EventArgs e)
        {
            byte[] buff = new byte[2048];
            string json;

            if (Connect == null)
                return;

            try
            {
                if (!Connect.Connected)
                    return;

                //prepare it into a json
                json = JsonConvert.SerializeObject("      ");
                log.Write($"Json sending: {json}");

                //send it back
                Connect.Send(Encoding.UTF8.GetBytes(json));


            }
            catch (Exception err)
            {
                log.Write($"Sent wrong {err.Message}");
            }
        }

        /// <summary>
        /// Send a bad array of bytes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBadFrame_Click(object sender, EventArgs e)
        {
            byte[] send = new byte[2048];

            send = new byte[] { 0x44, 0x72, 0x61, 0x67, 0x6f, 0x6e, 0x73 };

            if (Connect == null)
                return;

            try
            {
                if (!Connect.Connected)
                    return;
                //send it back
                Connect.Send(send);

            }
            catch (Exception err)
            {
                log.Write($"Sent wrong {err.Message}");
            }
        }
    }

    //public class we might have agreed on? 
    /// <summary>
    /// We agreed on this as a class and I dunno man
    /// </summary>
    public class GGData
    { 
        public int Num { get; set; } 

        public GGData(int num)
        {
            Num = num;
        }
    }

    /// <summary>
    /// bad evil fake class
    /// </summary>
    public class Fakeie
    {
        public string Num { get; set; }

        public Fakeie(string num)
        {
            Num = num;
        }
    }
}
