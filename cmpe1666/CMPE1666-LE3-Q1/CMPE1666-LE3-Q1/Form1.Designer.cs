
namespace CMPE1666_LE3_Q1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UI_BTN_Start = new System.Windows.Forms.Button();
            this.UI_BTN_Stop = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // UI_BTN_Start
            // 
            this.UI_BTN_Start.Location = new System.Drawing.Point(63, 57);
            this.UI_BTN_Start.Name = "UI_BTN_Start";
            this.UI_BTN_Start.Size = new System.Drawing.Size(75, 23);
            this.UI_BTN_Start.TabIndex = 0;
            this.UI_BTN_Start.Text = "Start";
            this.UI_BTN_Start.UseVisualStyleBackColor = true;
            this.UI_BTN_Start.Click += new System.EventHandler(this.UI_BTN_Start_Click);
            // 
            // UI_BTN_Stop
            // 
            this.UI_BTN_Stop.Location = new System.Drawing.Point(63, 86);
            this.UI_BTN_Stop.Name = "UI_BTN_Stop";
            this.UI_BTN_Stop.Size = new System.Drawing.Size(75, 23);
            this.UI_BTN_Stop.TabIndex = 1;
            this.UI_BTN_Stop.Text = "Stop All";
            this.UI_BTN_Stop.UseVisualStyleBackColor = true;
            this.UI_BTN_Stop.Click += new System.EventHandler(this.UI_BTN_Stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_BTN_Stop);
            this.Controls.Add(this.UI_BTN_Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UI_BTN_Start;
        private System.Windows.Forms.Button UI_BTN_Stop;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

