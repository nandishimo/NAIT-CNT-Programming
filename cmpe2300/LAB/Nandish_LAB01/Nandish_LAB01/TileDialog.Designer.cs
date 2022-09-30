namespace Nandish_LAB01
{
  partial class TileDialog
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
      this._lblChar = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // _lblChar
      // 
      this._lblChar.AutoSize = true;
      this._lblChar.Dock = System.Windows.Forms.DockStyle.Fill;
      this._lblChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._lblChar.Location = new System.Drawing.Point(0, 0);
      this._lblChar.Name = "_lblChar";
      this._lblChar.Size = new System.Drawing.Size(75, 73);
      this._lblChar.TabIndex = 0;
      this._lblChar.Text = "A";
      // 
      // TileDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(134, 111);
      this.ControlBox = false;
      this.Controls.Add(this._lblChar);
      this.Name = "TileDialog";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
      this.Text = "Tile";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label _lblChar;
    }
}