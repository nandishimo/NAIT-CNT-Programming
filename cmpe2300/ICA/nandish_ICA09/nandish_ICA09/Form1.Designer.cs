namespace nandish_ICA09
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
      this.components = new System.ComponentModel.Container();
      this._btn_Simulate = new System.Windows.Forms.Button();
      this._lbl_Remaining = new System.Windows.Forms.Label();
      this._timer = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // _btn_Simulate
      // 
      this._btn_Simulate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._btn_Simulate.Location = new System.Drawing.Point(12, 12);
      this._btn_Simulate.Name = "_btn_Simulate";
      this._btn_Simulate.Size = new System.Drawing.Size(150, 50);
      this._btn_Simulate.TabIndex = 0;
      this._btn_Simulate.Text = "button1";
      this._btn_Simulate.UseVisualStyleBackColor = true;
      // 
      // _lbl_Remaining
      // 
      this._lbl_Remaining.AutoSize = true;
      this._lbl_Remaining.BackColor = System.Drawing.SystemColors.Info;
      this._lbl_Remaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._lbl_Remaining.Location = new System.Drawing.Point(168, 12);
      this._lbl_Remaining.MinimumSize = new System.Drawing.Size(300, 50);
      this._lbl_Remaining.Name = "_lbl_Remaining";
      this._lbl_Remaining.Size = new System.Drawing.Size(300, 50);
      this._lbl_Remaining.TabIndex = 1;
      this._lbl_Remaining.Text = "label1";
      this._lbl_Remaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(481, 74);
      this.Controls.Add(this._lbl_Remaining);
      this.Controls.Add(this._btn_Simulate);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button _btn_Simulate;
        private System.Windows.Forms.Label _lbl_Remaining;
        private System.Windows.Forms.Timer _timer;
    }
}

