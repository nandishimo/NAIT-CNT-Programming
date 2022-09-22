namespace nandish_ica02
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
      this._lblX = new System.Windows.Forms.Label();
      this._lblY = new System.Windows.Forms.Label();
      this._cBoxAll = new System.Windows.Forms.CheckBox();
      this._lblXVal = new System.Windows.Forms.Label();
      this._lblYVal = new System.Windows.Forms.Label();
      this._lblBallData = new System.Windows.Forms.Label();
      this._lblOpacityVal = new System.Windows.Forms.Label();
      this._lblOpacity = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // _lblX
      // 
      this._lblX.AutoSize = true;
      this._lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._lblX.Location = new System.Drawing.Point(12, 9);
      this._lblX.Name = "_lblX";
      this._lblX.Size = new System.Drawing.Size(29, 24);
      this._lblX.TabIndex = 0;
      this._lblX.Text = "X:";
      // 
      // _lblY
      // 
      this._lblY.AutoSize = true;
      this._lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._lblY.Location = new System.Drawing.Point(130, 9);
      this._lblY.Name = "_lblY";
      this._lblY.Size = new System.Drawing.Size(27, 24);
      this._lblY.TabIndex = 2;
      this._lblY.Text = "Y:";
      // 
      // _cBoxAll
      // 
      this._cBoxAll.AutoSize = true;
      this._cBoxAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._cBoxAll.Location = new System.Drawing.Point(16, 49);
      this._cBoxAll.Name = "_cBoxAll";
      this._cBoxAll.Size = new System.Drawing.Size(50, 28);
      this._cBoxAll.TabIndex = 4;
      this._cBoxAll.Text = "All";
      this._cBoxAll.UseVisualStyleBackColor = true;
      // 
      // _lblXVal
      // 
      this._lblXVal.AutoSize = true;
      this._lblXVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this._lblXVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._lblXVal.Location = new System.Drawing.Point(47, 9);
      this._lblXVal.Name = "_lblXVal";
      this._lblXVal.Size = new System.Drawing.Size(20, 24);
      this._lblXVal.TabIndex = 5;
      this._lblXVal.Text = "0";
      // 
      // _lblYVal
      // 
      this._lblYVal.AutoSize = true;
      this._lblYVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this._lblYVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._lblYVal.Location = new System.Drawing.Point(163, 9);
      this._lblYVal.Name = "_lblYVal";
      this._lblYVal.Size = new System.Drawing.Size(20, 24);
      this._lblYVal.TabIndex = 6;
      this._lblYVal.Text = "0";
      // 
      // _lblBallData
      // 
      this._lblBallData.AutoSize = true;
      this._lblBallData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this._lblBallData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._lblBallData.Location = new System.Drawing.Point(12, 94);
      this._lblBallData.MinimumSize = new System.Drawing.Size(500, 0);
      this._lblBallData.Name = "_lblBallData";
      this._lblBallData.Size = new System.Drawing.Size(500, 24);
      this._lblBallData.TabIndex = 7;
      // 
      // _lblOpacityVal
      // 
      this._lblOpacityVal.AutoSize = true;
      this._lblOpacityVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this._lblOpacityVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._lblOpacityVal.Location = new System.Drawing.Point(319, 9);
      this._lblOpacityVal.Name = "_lblOpacityVal";
      this._lblOpacityVal.Size = new System.Drawing.Size(40, 24);
      this._lblOpacityVal.TabIndex = 9;
      this._lblOpacityVal.Text = "128";
      // 
      // _lblOpacity
      // 
      this._lblOpacity.AutoSize = true;
      this._lblOpacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._lblOpacity.Location = new System.Drawing.Point(235, 9);
      this._lblOpacity.Name = "_lblOpacity";
      this._lblOpacity.Size = new System.Drawing.Size(78, 24);
      this._lblOpacity.TabIndex = 8;
      this._lblOpacity.Text = "Opacity:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(534, 132);
      this.Controls.Add(this._lblOpacityVal);
      this.Controls.Add(this._lblOpacity);
      this.Controls.Add(this._lblBallData);
      this.Controls.Add(this._lblYVal);
      this.Controls.Add(this._lblXVal);
      this.Controls.Add(this._cBoxAll);
      this.Controls.Add(this._lblY);
      this.Controls.Add(this._lblX);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label _lblX;
    private System.Windows.Forms.Label _lblY;
    private System.Windows.Forms.CheckBox _cBoxAll;
    private System.Windows.Forms.Label _lblXVal;
    private System.Windows.Forms.Label _lblYVal;
    private System.Windows.Forms.Label _lblBallData;
    private System.Windows.Forms.Label _lblOpacityVal;
    private System.Windows.Forms.Label _lblOpacity;
  }
}

