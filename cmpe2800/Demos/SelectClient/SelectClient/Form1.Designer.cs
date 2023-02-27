namespace SelectClient
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
			this.UI_btn_connect = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// UI_btn_connect
			// 
			this.UI_btn_connect.Location = new System.Drawing.Point(389, 159);
			this.UI_btn_connect.Name = "UI_btn_connect";
			this.UI_btn_connect.Size = new System.Drawing.Size(75, 23);
			this.UI_btn_connect.TabIndex = 0;
			this.UI_btn_connect.Text = "button1";
			this.UI_btn_connect.UseVisualStyleBackColor = true;
			this.UI_btn_connect.Click += new System.EventHandler(this.UI_btn_connect_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.UI_btn_connect);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button UI_btn_connect;
	}
}

