namespace SocketICA
{
	partial class ConnectDialog
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.UI_tb_Address = new System.Windows.Forms.TextBox();
			this.UI_tb_Port = new System.Windows.Forms.TextBox();
			this.UI_btn_Connect = new System.Windows.Forms.Button();
			this.UI_btn_Cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "IP Address:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(77, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Port:";
			// 
			// UI_tb_Address
			// 
			this.UI_tb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UI_tb_Address.Location = new System.Drawing.Point(140, 39);
			this.UI_tb_Address.Name = "UI_tb_Address";
			this.UI_tb_Address.Size = new System.Drawing.Size(226, 31);
			this.UI_tb_Address.TabIndex = 2;
			// 
			// UI_tb_Port
			// 
			this.UI_tb_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UI_tb_Port.Location = new System.Drawing.Point(140, 76);
			this.UI_tb_Port.Name = "UI_tb_Port";
			this.UI_tb_Port.Size = new System.Drawing.Size(79, 31);
			this.UI_tb_Port.TabIndex = 3;
			// 
			// UI_btn_Connect
			// 
			this.UI_btn_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UI_btn_Connect.Location = new System.Drawing.Point(140, 113);
			this.UI_btn_Connect.Name = "UI_btn_Connect";
			this.UI_btn_Connect.Size = new System.Drawing.Size(79, 32);
			this.UI_btn_Connect.TabIndex = 4;
			this.UI_btn_Connect.Text = "Connect";
			this.UI_btn_Connect.UseVisualStyleBackColor = true;
			// 
			// UI_btn_Cancel
			// 
			this.UI_btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UI_btn_Cancel.Location = new System.Drawing.Point(242, 113);
			this.UI_btn_Cancel.Name = "UI_btn_Cancel";
			this.UI_btn_Cancel.Size = new System.Drawing.Size(70, 32);
			this.UI_btn_Cancel.TabIndex = 5;
			this.UI_btn_Cancel.Text = "Cancel";
			this.UI_btn_Cancel.UseVisualStyleBackColor = true;
			// 
			// ConnectDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(443, 155);
			this.Controls.Add(this.UI_btn_Cancel);
			this.Controls.Add(this.UI_btn_Connect);
			this.Controls.Add(this.UI_tb_Port);
			this.Controls.Add(this.UI_tb_Address);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "ConnectDialog";
			this.Text = "Connection Dialog";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox UI_tb_Address;
		private System.Windows.Forms.TextBox UI_tb_Port;
		private System.Windows.Forms.Button UI_btn_Connect;
		private System.Windows.Forms.Button UI_btn_Cancel;
	}
}

