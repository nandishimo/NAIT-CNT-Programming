namespace NandishPatel_Demo01
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
      this.lbl_Capture = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lbl_Wheel = new System.Windows.Forms.Label();
      this._pb = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this._pb)).BeginInit();
      this.SuspendLayout();
      // 
      // lbl_Capture
      // 
      this.lbl_Capture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbl_Capture.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.lbl_Capture.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_Capture.Location = new System.Drawing.Point(139, 7);
      this.lbl_Capture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lbl_Capture.Name = "lbl_Capture";
      this.lbl_Capture.Size = new System.Drawing.Size(175, 32);
      this.lbl_Capture.TabIndex = 9;
      this.lbl_Capture.Text = "label4";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(9, 50);
      this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(105, 31);
      this.label3.TabIndex = 8;
      this.label3.Text = "Wheel :";
      // 
      // lbl_Wheel
      // 
      this.lbl_Wheel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbl_Wheel.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.lbl_Wheel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_Wheel.Location = new System.Drawing.Point(139, 50);
      this.lbl_Wheel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lbl_Wheel.Name = "lbl_Wheel";
      this.lbl_Wheel.Size = new System.Drawing.Size(175, 32);
      this.lbl_Wheel.TabIndex = 7;
      this.lbl_Wheel.Text = "label2";
      // 
      // _pb
      // 
      this._pb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this._pb.Location = new System.Drawing.Point(9, 114);
      this._pb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this._pb.Name = "_pb";
      this._pb.Size = new System.Drawing.Size(305, 254);
      this._pb.TabIndex = 6;
      this._pb.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(9, 7);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(126, 31);
      this.label1.TabIndex = 5;
      this.label1.Text = "Capture :";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(323, 377);
      this.Controls.Add(this.lbl_Capture);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.lbl_Wheel);
      this.Controls.Add(this._pb);
      this.Controls.Add(this.label1);
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this._pb)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label lbl_Capture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Wheel;
        private System.Windows.Forms.PictureBox _pb;
        private System.Windows.Forms.Label label1;
    }
}

