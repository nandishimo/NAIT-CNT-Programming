namespace Nandish_ICA04
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
      this._tBarBallSize = new System.Windows.Forms.TrackBar();
      this._btnAddBalls = new System.Windows.Forms.Button();
      this._pBar = new System.Windows.Forms.ProgressBar();
      ((System.ComponentModel.ISupportInitialize)(this._tBarBallSize)).BeginInit();
      this.SuspendLayout();
      // 
      // _tBarBallSize
      // 
      this._tBarBallSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this._tBarBallSize.Location = new System.Drawing.Point(12, 12);
      this._tBarBallSize.Maximum = 50;
      this._tBarBallSize.Minimum = -50;
      this._tBarBallSize.Name = "_tBarBallSize";
      this._tBarBallSize.Size = new System.Drawing.Size(385, 71);
      this._tBarBallSize.TabIndex = 0;
      this._tBarBallSize.TickFrequency = 5;
      // 
      // _btnAddBalls
      // 
      this._btnAddBalls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this._btnAddBalls.Location = new System.Drawing.Point(12, 63);
      this._btnAddBalls.Name = "_btnAddBalls";
      this._btnAddBalls.Size = new System.Drawing.Size(385, 33);
      this._btnAddBalls.TabIndex = 1;
      this._btnAddBalls.Text = "button1";
      this._btnAddBalls.UseVisualStyleBackColor = true;
      // 
      // _pBar
      // 
      this._pBar.Location = new System.Drawing.Point(12, 102);
      this._pBar.Maximum = 1000;
      this._pBar.Name = "_pBar";
      this._pBar.Size = new System.Drawing.Size(385, 23);
      this._pBar.TabIndex = 2;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(409, 132);
      this.Controls.Add(this._pBar);
      this.Controls.Add(this._btnAddBalls);
      this.Controls.Add(this._tBarBallSize);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this._tBarBallSize)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TrackBar _tBarBallSize;
    private System.Windows.Forms.Button _btnAddBalls;
    private System.Windows.Forms.ProgressBar _pBar;
  }
}

