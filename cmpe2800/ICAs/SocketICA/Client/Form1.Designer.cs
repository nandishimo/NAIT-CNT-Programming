namespace Client
{
	partial class ClientForm
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
			this.UI_btn_Connect = new System.Windows.Forms.Button();
			this.UI_btn_Send = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// UI_btn_Connect
			// 
			this.UI_btn_Connect.Location = new System.Drawing.Point(117, 113);
			this.UI_btn_Connect.Name = "UI_btn_Connect";
			this.UI_btn_Connect.Size = new System.Drawing.Size(75, 23);
			this.UI_btn_Connect.TabIndex = 0;
			this.UI_btn_Connect.Text = "Connect";
			this.UI_btn_Connect.UseVisualStyleBackColor = true;
			this.UI_btn_Connect.Click += new System.EventHandler(this.UI_btn_Connect_Click);
			// 
			// UI_btn_Send
			// 
			this.UI_btn_Send.Location = new System.Drawing.Point(117, 162);
			this.UI_btn_Send.Name = "UI_btn_Send";
			this.UI_btn_Send.Size = new System.Drawing.Size(75, 23);
			this.UI_btn_Send.TabIndex = 1;
			this.UI_btn_Send.Text = "Send Data";
			this.UI_btn_Send.UseVisualStyleBackColor = true;
			this.UI_btn_Send.Click += new System.EventHandler(this.UI_btn_Send_Click);
			// 
			// ClientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.UI_btn_Send);
			this.Controls.Add(this.UI_btn_Connect);
			this.Name = "ClientForm";
			this.Text = "Client";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button UI_btn_Connect;
		private System.Windows.Forms.Button UI_btn_Send;
	}
}

