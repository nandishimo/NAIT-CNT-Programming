namespace Nandish_ICA05
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
      this._lblSize = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this._rbColor = new System.Windows.Forms.RadioButton();
      this._rbDistance = new System.Windows.Forms.RadioButton();
      this._rbRadius = new System.Windows.Forms.RadioButton();
      this._pBar = new System.Windows.Forms.ProgressBar();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // _lblSize
      // 
      this._lblSize.AutoSize = true;
      this._lblSize.Location = new System.Drawing.Point(9, 9);
      this._lblSize.MinimumSize = new System.Drawing.Size(400, 50);
      this._lblSize.Name = "_lblSize";
      this._lblSize.Size = new System.Drawing.Size(400, 50);
      this._lblSize.TabIndex = 0;
      this._lblSize.Text = "label1";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this._rbColor);
      this.groupBox1.Controls.Add(this._rbDistance);
      this.groupBox1.Controls.Add(this._rbRadius);
      this.groupBox1.Location = new System.Drawing.Point(12, 62);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(249, 53);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Sort Type";
      // 
      // _rbColor
      // 
      this._rbColor.AutoSize = true;
      this._rbColor.Location = new System.Drawing.Point(188, 19);
      this._rbColor.Name = "_rbColor";
      this._rbColor.Size = new System.Drawing.Size(49, 17);
      this._rbColor.TabIndex = 2;
      this._rbColor.TabStop = true;
      this._rbColor.Text = "Color";
      this._rbColor.UseVisualStyleBackColor = true;
      this._rbColor.Click += new System.EventHandler(this._rbClick);
      // 
      // _rbDistance
      // 
      this._rbDistance.AutoSize = true;
      this._rbDistance.Location = new System.Drawing.Point(97, 19);
      this._rbDistance.Name = "_rbDistance";
      this._rbDistance.Size = new System.Drawing.Size(67, 17);
      this._rbDistance.TabIndex = 1;
      this._rbDistance.TabStop = true;
      this._rbDistance.Text = "Distance";
      this._rbDistance.UseVisualStyleBackColor = true;
      this._rbDistance.Click += new System.EventHandler(this._rbClick);
      // 
      // _rbRadius
      // 
      this._rbRadius.AutoSize = true;
      this._rbRadius.Location = new System.Drawing.Point(6, 19);
      this._rbRadius.Name = "_rbRadius";
      this._rbRadius.Size = new System.Drawing.Size(58, 17);
      this._rbRadius.TabIndex = 0;
      this._rbRadius.TabStop = true;
      this._rbRadius.Text = "Radius";
      this._rbRadius.UseVisualStyleBackColor = true;
      this._rbRadius.Click += new System.EventHandler(this._rbClick);
      // 
      // _pBar
      // 
      this._pBar.Location = new System.Drawing.Point(0, 121);
      this._pBar.Name = "_pBar";
      this._pBar.Size = new System.Drawing.Size(418, 51);
      this._pBar.TabIndex = 2;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(418, 172);
      this.Controls.Add(this._pBar);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this._lblSize);
      this.Name = "Form1";
      this.Text = "Form1";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label _lblSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton _rbColor;
        private System.Windows.Forms.RadioButton _rbDistance;
        private System.Windows.Forms.RadioButton _rbRadius;
        private System.Windows.Forms.ProgressBar _pBar;
    }
}

