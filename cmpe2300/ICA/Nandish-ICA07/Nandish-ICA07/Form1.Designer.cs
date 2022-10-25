namespace Nandish_ICA07
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
      this._btnPopulate = new System.Windows.Forms.Button();
      this._btnColor = new System.Windows.Forms.Button();
      this._btnWidth = new System.Windows.Forms.Button();
      this._btnWDesc = new System.Windows.Forms.Button();
      this._btnWColor = new System.Windows.Forms.Button();
      this._btnBright = new System.Windows.Forms.Button();
      this._btnLong = new System.Windows.Forms.Button();
      this._tBar = new System.Windows.Forms.TrackBar();
      ((System.ComponentModel.ISupportInitialize)(this._tBar)).BeginInit();
      this.SuspendLayout();
      // 
      // _btnPopulate
      // 
      this._btnPopulate.Location = new System.Drawing.Point(12, 12);
      this._btnPopulate.Name = "_btnPopulate";
      this._btnPopulate.Size = new System.Drawing.Size(348, 35);
      this._btnPopulate.TabIndex = 0;
      this._btnPopulate.Text = "Populate";
      this._btnPopulate.UseVisualStyleBackColor = true;
      this._btnPopulate.Click += new System.EventHandler(this._btnPopulate_Click);
      // 
      // _btnColor
      // 
      this._btnColor.Location = new System.Drawing.Point(12, 53);
      this._btnColor.Name = "_btnColor";
      this._btnColor.Size = new System.Drawing.Size(348, 35);
      this._btnColor.TabIndex = 1;
      this._btnColor.Text = "Color";
      this._btnColor.UseVisualStyleBackColor = true;
      this._btnColor.Click += new System.EventHandler(this._btnColor_Click);
      // 
      // _btnWidth
      // 
      this._btnWidth.Location = new System.Drawing.Point(12, 94);
      this._btnWidth.Name = "_btnWidth";
      this._btnWidth.Size = new System.Drawing.Size(348, 35);
      this._btnWidth.TabIndex = 2;
      this._btnWidth.Text = "Width";
      this._btnWidth.UseVisualStyleBackColor = true;
      this._btnWidth.Click += new System.EventHandler(this._btnWidth_Click);
      // 
      // _btnWDesc
      // 
      this._btnWDesc.Location = new System.Drawing.Point(12, 135);
      this._btnWDesc.Name = "_btnWDesc";
      this._btnWDesc.Size = new System.Drawing.Size(348, 35);
      this._btnWDesc.TabIndex = 3;
      this._btnWDesc.Text = "Width Desc";
      this._btnWDesc.UseVisualStyleBackColor = true;
      this._btnWDesc.Click += new System.EventHandler(this._btnWDesc_Click);
      // 
      // _btnWColor
      // 
      this._btnWColor.Location = new System.Drawing.Point(12, 176);
      this._btnWColor.Name = "_btnWColor";
      this._btnWColor.Size = new System.Drawing.Size(348, 35);
      this._btnWColor.TabIndex = 4;
      this._btnWColor.Text = "Width, Color";
      this._btnWColor.UseVisualStyleBackColor = true;
      this._btnWColor.Click += new System.EventHandler(this._btnWColor_Click);
      // 
      // _btnBright
      // 
      this._btnBright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._btnBright.Location = new System.Drawing.Point(12, 217);
      this._btnBright.Name = "_btnBright";
      this._btnBright.Size = new System.Drawing.Size(348, 35);
      this._btnBright.TabIndex = 5;
      this._btnBright.Text = "Bright";
      this._btnBright.UseVisualStyleBackColor = true;
      this._btnBright.Click += new System.EventHandler(this._btnBright_Click);
      // 
      // _btnLong
      // 
      this._btnLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._btnLong.Location = new System.Drawing.Point(12, 258);
      this._btnLong.Name = "_btnLong";
      this._btnLong.Size = new System.Drawing.Size(348, 35);
      this._btnLong.TabIndex = 6;
      this._btnLong.Text = "Longer than #";
      this._btnLong.UseVisualStyleBackColor = true;
      this._btnLong.Click += new System.EventHandler(this._btnLong_Click);
      // 
      // _tBar
      // 
      this._tBar.Location = new System.Drawing.Point(12, 299);
      this._tBar.Maximum = 190;
      this._tBar.Minimum = 10;
      this._tBar.Name = "_tBar";
      this._tBar.Size = new System.Drawing.Size(348, 45);
      this._tBar.TabIndex = 7;
      this._tBar.Value = 10;
      this._tBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(372, 388);
      this.Controls.Add(this._tBar);
      this.Controls.Add(this._btnLong);
      this.Controls.Add(this._btnBright);
      this.Controls.Add(this._btnWColor);
      this.Controls.Add(this._btnWDesc);
      this.Controls.Add(this._btnWidth);
      this.Controls.Add(this._btnColor);
      this.Controls.Add(this._btnPopulate);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this._tBar)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button _btnPopulate;
    private System.Windows.Forms.Button _btnColor;
    private System.Windows.Forms.Button _btnWidth;
    private System.Windows.Forms.Button _btnWDesc;
    private System.Windows.Forms.Button _btnWColor;
    private System.Windows.Forms.Button _btnBright;
    private System.Windows.Forms.Button _btnLong;
    private System.Windows.Forms.TrackBar _tBar;
  }
}

