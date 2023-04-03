namespace NumberGuesserServer
{
    partial class SERVER
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
            this.lblNum = new System.Windows.Forms.Label();
            this.btnWrong = new System.Windows.Forms.Button();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.btnBadFrame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(103, 28);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(39, 13);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "lblNum";
            // 
            // btnWrong
            // 
            this.btnWrong.Location = new System.Drawing.Point(12, 12);
            this.btnWrong.Name = "btnWrong";
            this.btnWrong.Size = new System.Drawing.Size(75, 23);
            this.btnWrong.TabIndex = 1;
            this.btnWrong.Text = "Wrong Json";
            this.btnWrong.UseVisualStyleBackColor = true;
            this.btnWrong.Click += new System.EventHandler(this.btnWrong_Click);
            // 
            // btnEmpty
            // 
            this.btnEmpty.Location = new System.Drawing.Point(12, 41);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(75, 23);
            this.btnEmpty.TabIndex = 2;
            this.btnEmpty.Text = "Empty String";
            this.btnEmpty.UseVisualStyleBackColor = true;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // btnBadFrame
            // 
            this.btnBadFrame.Location = new System.Drawing.Point(12, 73);
            this.btnBadFrame.Name = "btnBadFrame";
            this.btnBadFrame.Size = new System.Drawing.Size(75, 23);
            this.btnBadFrame.TabIndex = 3;
            this.btnBadFrame.Text = "Bad Frame";
            this.btnBadFrame.UseVisualStyleBackColor = true;
            this.btnBadFrame.Click += new System.EventHandler(this.btnBadFrame_Click);
            // 
            // SERVER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(257, 108);
            this.Controls.Add(this.btnBadFrame);
            this.Controls.Add(this.btnEmpty);
            this.Controls.Add(this.btnWrong);
            this.Controls.Add(this.lblNum);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SERVER";
            this.ShowInTaskbar = false;
            this.Text = "SERVER";
            this.Load += new System.EventHandler(this.SERVER_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnWrong;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.Button btnBadFrame;
    }
}

