namespace Nandish_LAB01
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
      this._lblTileSets = new System.Windows.Forms.Label();
      this._lblMatchCount = new System.Windows.Forms.Label();
      this._cbCheat = new System.Windows.Forms.CheckBox();
      this._butStart = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // _lblTileSets
      // 
      this._lblTileSets.AutoSize = true;
      this._lblTileSets.Location = new System.Drawing.Point(12, 17);
      this._lblTileSets.Name = "_lblTileSets";
      this._lblTileSets.Size = new System.Drawing.Size(66, 13);
      this._lblTileSets.TabIndex = 0;
      this._lblTileSets.Text = "Tile Sets: 10";
      // 
      // _lblMatchCount
      // 
      this._lblMatchCount.AutoSize = true;
      this._lblMatchCount.Location = new System.Drawing.Point(90, 17);
      this._lblMatchCount.Name = "_lblMatchCount";
      this._lblMatchCount.Size = new System.Drawing.Size(60, 13);
      this._lblMatchCount.TabIndex = 1;
      this._lblMatchCount.Text = "Matches: 2";
      // 
      // _cbCheat
      // 
      this._cbCheat.AutoSize = true;
      this._cbCheat.Location = new System.Drawing.Point(179, 16);
      this._cbCheat.Name = "_cbCheat";
      this._cbCheat.Size = new System.Drawing.Size(54, 17);
      this._cbCheat.TabIndex = 2;
      this._cbCheat.Text = "Cheat";
      this._cbCheat.UseVisualStyleBackColor = true;
      // 
      // _butStart
      // 
      this._butStart.Location = new System.Drawing.Point(291, 12);
      this._butStart.Name = "_butStart";
      this._butStart.Size = new System.Drawing.Size(132, 23);
      this._butStart.TabIndex = 3;
      this._butStart.Text = "Start";
      this._butStart.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(436, 49);
      this.Controls.Add(this._butStart);
      this.Controls.Add(this._cbCheat);
      this.Controls.Add(this._lblMatchCount);
      this.Controls.Add(this._lblTileSets);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label _lblTileSets;
    private System.Windows.Forms.Label _lblMatchCount;
    private System.Windows.Forms.CheckBox _cbCheat;
    private System.Windows.Forms.Button _butStart;
  }
}

