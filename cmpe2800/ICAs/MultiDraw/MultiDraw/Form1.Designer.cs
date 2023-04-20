namespace MultiDraw
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
			this.UI_btn_Connect = new System.Windows.Forms.Button();
			this.UI_lbl_Thickness = new System.Windows.Forms.Label();
			this.UI_lbl_Frames = new System.Windows.Forms.Label();
			this.UI_lbl_Fragments = new System.Windows.Forms.Label();
			this.UI_lbl_Destack = new System.Windows.Forms.Label();
			this.UI_lbl_Bytes = new System.Windows.Forms.Label();
			this.UI_lbl_Color = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// UI_btn_Connect
			// 
			this.UI_btn_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UI_btn_Connect.Location = new System.Drawing.Point(12, 420);
			this.UI_btn_Connect.Name = "UI_btn_Connect";
			this.UI_btn_Connect.Size = new System.Drawing.Size(107, 26);
			this.UI_btn_Connect.TabIndex = 0;
			this.UI_btn_Connect.Text = "Connect / Disc";
			this.UI_btn_Connect.UseVisualStyleBackColor = true;
			this.UI_btn_Connect.Click += new System.EventHandler(this.UI_btn_Connect_Click);
			// 
			// UI_lbl_Thickness
			// 
			this.UI_lbl_Thickness.AutoSize = true;
			this.UI_lbl_Thickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UI_lbl_Thickness.Location = new System.Drawing.Point(201, 425);
			this.UI_lbl_Thickness.Name = "UI_lbl_Thickness";
			this.UI_lbl_Thickness.Size = new System.Drawing.Size(89, 16);
			this.UI_lbl_Thickness.TabIndex = 2;
			this.UI_lbl_Thickness.Text = "Thickness: 10";
			// 
			// UI_lbl_Frames
			// 
			this.UI_lbl_Frames.AutoSize = true;
			this.UI_lbl_Frames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UI_lbl_Frames.Location = new System.Drawing.Point(296, 425);
			this.UI_lbl_Frames.Name = "UI_lbl_Frames";
			this.UI_lbl_Frames.Size = new System.Drawing.Size(124, 16);
			this.UI_lbl_Frames.TabIndex = 3;
			this.UI_lbl_Frames.Text = "Frames RXed: 0000";
			// 
			// UI_lbl_Fragments
			// 
			this.UI_lbl_Fragments.AutoSize = true;
			this.UI_lbl_Fragments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UI_lbl_Fragments.Location = new System.Drawing.Point(426, 425);
			this.UI_lbl_Fragments.Name = "UI_lbl_Fragments";
			this.UI_lbl_Fragments.Size = new System.Drawing.Size(98, 16);
			this.UI_lbl_Fragments.TabIndex = 4;
			this.UI_lbl_Fragments.Text = "Fragments: 000";
			// 
			// UI_lbl_Destack
			// 
			this.UI_lbl_Destack.AutoSize = true;
			this.UI_lbl_Destack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UI_lbl_Destack.Location = new System.Drawing.Point(530, 425);
			this.UI_lbl_Destack.Name = "UI_lbl_Destack";
			this.UI_lbl_Destack.Size = new System.Drawing.Size(114, 16);
			this.UI_lbl_Destack.TabIndex = 5;
			this.UI_lbl_Destack.Text = "Destack Avg: 0.00";
			// 
			// UI_lbl_Bytes
			// 
			this.UI_lbl_Bytes.AutoSize = true;
			this.UI_lbl_Bytes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UI_lbl_Bytes.Location = new System.Drawing.Point(650, 425);
			this.UI_lbl_Bytes.Name = "UI_lbl_Bytes";
			this.UI_lbl_Bytes.Size = new System.Drawing.Size(138, 16);
			this.UI_lbl_Bytes.TabIndex = 6;
			this.UI_lbl_Bytes.Text = "Bytes RXed: 0.00E+00";
			this.UI_lbl_Bytes.Click += new System.EventHandler(this.UI_lbl_Bytes_Click);
			// 
			// UI_lbl_Color
			// 
			this.UI_lbl_Color.AutoSize = true;
			this.UI_lbl_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UI_lbl_Color.Location = new System.Drawing.Point(125, 425);
			this.UI_lbl_Color.Name = "UI_lbl_Color";
			this.UI_lbl_Color.Size = new System.Drawing.Size(42, 16);
			this.UI_lbl_Color.TabIndex = 7;
			this.UI_lbl_Color.Text = "Color:";
			this.UI_lbl_Color.Click += new System.EventHandler(this.UI_lbl_Color_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.UI_lbl_Color);
			this.Controls.Add(this.UI_lbl_Bytes);
			this.Controls.Add(this.UI_lbl_Destack);
			this.Controls.Add(this.UI_lbl_Fragments);
			this.Controls.Add(this.UI_lbl_Frames);
			this.Controls.Add(this.UI_lbl_Thickness);
			this.Controls.Add(this.UI_btn_Connect);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button UI_btn_Connect;
		private System.Windows.Forms.Label UI_lbl_Thickness;
		private System.Windows.Forms.Label UI_lbl_Frames;
		private System.Windows.Forms.Label UI_lbl_Fragments;
		private System.Windows.Forms.Label UI_lbl_Destack;
		private System.Windows.Forms.Label UI_lbl_Bytes;
		private System.Windows.Forms.Label UI_lbl_Color;
	}
}

