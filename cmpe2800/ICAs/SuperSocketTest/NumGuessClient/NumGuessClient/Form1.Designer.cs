namespace NumGuessClient
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
			this.UI_Btn_Connect = new System.Windows.Forms.Button();
			this.UI_Btn_Disconnect = new System.Windows.Forms.Button();
			this.UI_Tbar_Guess = new System.Windows.Forms.TrackBar();
			this.UI_Tbox_Min = new System.Windows.Forms.TextBox();
			this.UI_Tbox_Current = new System.Windows.Forms.TextBox();
			this.UI_Tbox_Max = new System.Windows.Forms.TextBox();
			this.UI_Tbox_Status = new System.Windows.Forms.TextBox();
			this.UI_Btn_Guess = new System.Windows.Forms.Button();
			this.UI_Btn_SendEmpty = new System.Windows.Forms.Button();
			this.UI_Btn_WrongJSON = new System.Windows.Forms.Button();
			this.UI_Btn_BadFrame = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.UI_Tbar_Guess)).BeginInit();
			this.SuspendLayout();
			// 
			// UI_Btn_Connect
			// 
			this.UI_Btn_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UI_Btn_Connect.Location = new System.Drawing.Point(12, 12);
			this.UI_Btn_Connect.Name = "UI_Btn_Connect";
			this.UI_Btn_Connect.Size = new System.Drawing.Size(85, 27);
			this.UI_Btn_Connect.TabIndex = 0;
			this.UI_Btn_Connect.Text = "Connect";
			this.UI_Btn_Connect.UseVisualStyleBackColor = true;
			this.UI_Btn_Connect.Click += new System.EventHandler(this.UI_Btn_Connect_Click);
			// 
			// UI_Btn_Disconnect
			// 
			this.UI_Btn_Disconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.UI_Btn_Disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UI_Btn_Disconnect.Location = new System.Drawing.Point(357, 12);
			this.UI_Btn_Disconnect.Name = "UI_Btn_Disconnect";
			this.UI_Btn_Disconnect.Size = new System.Drawing.Size(99, 27);
			this.UI_Btn_Disconnect.TabIndex = 1;
			this.UI_Btn_Disconnect.Text = "Disconnect";
			this.UI_Btn_Disconnect.UseVisualStyleBackColor = true;
			this.UI_Btn_Disconnect.Click += new System.EventHandler(this.UI_Btn_Disconnect_Click);
			// 
			// UI_Tbar_Guess
			// 
			this.UI_Tbar_Guess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UI_Tbar_Guess.Location = new System.Drawing.Point(13, 45);
			this.UI_Tbar_Guess.Maximum = 1000;
			this.UI_Tbar_Guess.Minimum = 1;
			this.UI_Tbar_Guess.Name = "UI_Tbar_Guess";
			this.UI_Tbar_Guess.Size = new System.Drawing.Size(444, 45);
			this.UI_Tbar_Guess.TabIndex = 2;
			this.UI_Tbar_Guess.TickFrequency = 10;
			this.UI_Tbar_Guess.Value = 1;
			this.UI_Tbar_Guess.Scroll += new System.EventHandler(this.UI_Tbar_Guess_Scroll);
			// 
			// UI_Tbox_Min
			// 
			this.UI_Tbox_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UI_Tbox_Min.Location = new System.Drawing.Point(13, 96);
			this.UI_Tbox_Min.Name = "UI_Tbox_Min";
			this.UI_Tbox_Min.ReadOnly = true;
			this.UI_Tbox_Min.Size = new System.Drawing.Size(57, 26);
			this.UI_Tbox_Min.TabIndex = 3;
			this.UI_Tbox_Min.Text = "1";
			// 
			// UI_Tbox_Current
			// 
			this.UI_Tbox_Current.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.UI_Tbox_Current.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UI_Tbox_Current.Location = new System.Drawing.Point(194, 96);
			this.UI_Tbox_Current.Name = "UI_Tbox_Current";
			this.UI_Tbox_Current.ReadOnly = true;
			this.UI_Tbox_Current.Size = new System.Drawing.Size(80, 26);
			this.UI_Tbox_Current.TabIndex = 4;
			this.UI_Tbox_Current.Text = "1";
			// 
			// UI_Tbox_Max
			// 
			this.UI_Tbox_Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.UI_Tbox_Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UI_Tbox_Max.Location = new System.Drawing.Point(402, 96);
			this.UI_Tbox_Max.Name = "UI_Tbox_Max";
			this.UI_Tbox_Max.ReadOnly = true;
			this.UI_Tbox_Max.Size = new System.Drawing.Size(55, 26);
			this.UI_Tbox_Max.TabIndex = 5;
			this.UI_Tbox_Max.Text = " 1000";
			// 
			// UI_Tbox_Status
			// 
			this.UI_Tbox_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.UI_Tbox_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UI_Tbox_Status.Location = new System.Drawing.Point(12, 164);
			this.UI_Tbox_Status.Name = "UI_Tbox_Status";
			this.UI_Tbox_Status.ReadOnly = true;
			this.UI_Tbox_Status.Size = new System.Drawing.Size(342, 26);
			this.UI_Tbox_Status.TabIndex = 6;
			this.UI_Tbox_Status.Text = "Connect to a server...";
			// 
			// UI_Btn_Guess
			// 
			this.UI_Btn_Guess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.UI_Btn_Guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UI_Btn_Guess.Location = new System.Drawing.Point(358, 163);
			this.UI_Btn_Guess.Name = "UI_Btn_Guess";
			this.UI_Btn_Guess.Size = new System.Drawing.Size(99, 27);
			this.UI_Btn_Guess.TabIndex = 7;
			this.UI_Btn_Guess.Text = "Guess";
			this.UI_Btn_Guess.UseVisualStyleBackColor = true;
			this.UI_Btn_Guess.Click += new System.EventHandler(this.UI_Btn_Guess_Click);
			// 
			// UI_Btn_SendEmpty
			// 
			this.UI_Btn_SendEmpty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UI_Btn_SendEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UI_Btn_SendEmpty.Location = new System.Drawing.Point(12, 131);
			this.UI_Btn_SendEmpty.Name = "UI_Btn_SendEmpty";
			this.UI_Btn_SendEmpty.Size = new System.Drawing.Size(139, 27);
			this.UI_Btn_SendEmpty.TabIndex = 8;
			this.UI_Btn_SendEmpty.Text = "Empty Data";
			this.UI_Btn_SendEmpty.UseVisualStyleBackColor = true;
			// 
			// UI_Btn_WrongJSON
			// 
			this.UI_Btn_WrongJSON.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UI_Btn_WrongJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UI_Btn_WrongJSON.Location = new System.Drawing.Point(157, 131);
			this.UI_Btn_WrongJSON.Name = "UI_Btn_WrongJSON";
			this.UI_Btn_WrongJSON.Size = new System.Drawing.Size(161, 27);
			this.UI_Btn_WrongJSON.TabIndex = 9;
			this.UI_Btn_WrongJSON.Text = "Wrong JSON";
			this.UI_Btn_WrongJSON.UseVisualStyleBackColor = true;
			// 
			// UI_Btn_BadFrame
			// 
			this.UI_Btn_BadFrame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UI_Btn_BadFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UI_Btn_BadFrame.Location = new System.Drawing.Point(324, 131);
			this.UI_Btn_BadFrame.Name = "UI_Btn_BadFrame";
			this.UI_Btn_BadFrame.Size = new System.Drawing.Size(133, 27);
			this.UI_Btn_BadFrame.TabIndex = 10;
			this.UI_Btn_BadFrame.Text = "Bad Frame";
			this.UI_Btn_BadFrame.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(469, 202);
			this.Controls.Add(this.UI_Btn_BadFrame);
			this.Controls.Add(this.UI_Btn_WrongJSON);
			this.Controls.Add(this.UI_Btn_SendEmpty);
			this.Controls.Add(this.UI_Btn_Guess);
			this.Controls.Add(this.UI_Tbox_Status);
			this.Controls.Add(this.UI_Tbox_Max);
			this.Controls.Add(this.UI_Tbox_Current);
			this.Controls.Add(this.UI_Tbox_Min);
			this.Controls.Add(this.UI_Tbar_Guess);
			this.Controls.Add(this.UI_Btn_Disconnect);
			this.Controls.Add(this.UI_Btn_Connect);
			this.MinimumSize = new System.Drawing.Size(485, 210);
			this.Name = "Form1";
			this.Text = "Number Guess!";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.UI_Tbar_Guess)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button UI_Btn_Connect;
		private System.Windows.Forms.Button UI_Btn_Disconnect;
		private System.Windows.Forms.TrackBar UI_Tbar_Guess;
		private System.Windows.Forms.TextBox UI_Tbox_Min;
		private System.Windows.Forms.TextBox UI_Tbox_Current;
		private System.Windows.Forms.TextBox UI_Tbox_Max;
		private System.Windows.Forms.TextBox UI_Tbox_Status;
		private System.Windows.Forms.Button UI_Btn_Guess;
		private System.Windows.Forms.Button UI_Btn_SendEmpty;
		private System.Windows.Forms.Button UI_Btn_WrongJSON;
		private System.Windows.Forms.Button UI_Btn_BadFrame;
	}
}

