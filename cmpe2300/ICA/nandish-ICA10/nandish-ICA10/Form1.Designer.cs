namespace nandish_ICA10
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
      this._btn_Average = new System.Windows.Forms.Button();
      this._lbl_FileName = new System.Windows.Forms.Label();
      this._dgv = new System.Windows.Forms.DataGridView();
      this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this._dgv)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
      this.SuspendLayout();
      // 
      // _btn_Average
      // 
      this._btn_Average.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this._btn_Average.Location = new System.Drawing.Point(12, 42);
      this._btn_Average.Name = "_btn_Average";
      this._btn_Average.Size = new System.Drawing.Size(150, 26);
      this._btn_Average.TabIndex = 0;
      this._btn_Average.Text = "button1";
      this._btn_Average.UseVisualStyleBackColor = true;
      // 
      // _lbl_FileName
      // 
      this._lbl_FileName.AutoSize = true;
      this._lbl_FileName.Location = new System.Drawing.Point(12, 9);
      this._lbl_FileName.MinimumSize = new System.Drawing.Size(150, 30);
      this._lbl_FileName.Name = "_lbl_FileName";
      this._lbl_FileName.Size = new System.Drawing.Size(150, 30);
      this._lbl_FileName.TabIndex = 1;
      this._lbl_FileName.Text = "label1";
      this._lbl_FileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // _dgv
      // 
      this._dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this._dgv.Location = new System.Drawing.Point(12, 74);
      this._dgv.Name = "_dgv";
      this._dgv.Size = new System.Drawing.Size(150, 364);
      this._dgv.TabIndex = 2;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(175, 450);
      this.Controls.Add(this._dgv);
      this.Controls.Add(this._lbl_FileName);
      this.Controls.Add(this._btn_Average);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this._dgv)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button _btn_Average;
    private System.Windows.Forms.Label _lbl_FileName;
    private System.Windows.Forms.DataGridView _dgv;
    private System.Windows.Forms.BindingSource bindingSource1;
  }
}

