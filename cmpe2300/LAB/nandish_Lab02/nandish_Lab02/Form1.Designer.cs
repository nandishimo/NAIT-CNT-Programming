namespace nandish_Lab02
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
      this._btn_Table = new System.Windows.Forms.Button();
      this._lbl_Friction = new System.Windows.Forms.Label();
      this._lbl_FrictionValue = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this._rb_TotalHits = new System.Windows.Forms.RadioButton();
      this._rb_Hits = new System.Windows.Forms.RadioButton();
      this._rb_Radius = new System.Windows.Forms.RadioButton();
      this._dgv = new System.Windows.Forms.DataGridView();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this._dgv)).BeginInit();
      this.SuspendLayout();
      // 
      // _btn_Table
      // 
      this._btn_Table.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._btn_Table.Location = new System.Drawing.Point(12, 12);
      this._btn_Table.Name = "_btn_Table";
      this._btn_Table.Size = new System.Drawing.Size(140, 23);
      this._btn_Table.TabIndex = 0;
      this._btn_Table.Text = "New Table [10]";
      this._btn_Table.UseVisualStyleBackColor = true;
      // 
      // _lbl_Friction
      // 
      this._lbl_Friction.AutoSize = true;
      this._lbl_Friction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._lbl_Friction.Location = new System.Drawing.Point(188, 17);
      this._lbl_Friction.Name = "_lbl_Friction";
      this._lbl_Friction.Size = new System.Drawing.Size(61, 13);
      this._lbl_Friction.TabIndex = 1;
      this._lbl_Friction.Text = "Friction : ";
      // 
      // _lbl_FrictionValue
      // 
      this._lbl_FrictionValue.AutoSize = true;
      this._lbl_FrictionValue.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this._lbl_FrictionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._lbl_FrictionValue.Location = new System.Drawing.Point(255, 17);
      this._lbl_FrictionValue.Name = "_lbl_FrictionValue";
      this._lbl_FrictionValue.Size = new System.Drawing.Size(39, 13);
      this._lbl_FrictionValue.TabIndex = 2;
      this._lbl_FrictionValue.Text = "0.991";
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this._rb_TotalHits);
      this.groupBox1.Controls.Add(this._rb_Hits);
      this.groupBox1.Controls.Add(this._rb_Radius);
      this.groupBox1.Location = new System.Drawing.Point(12, 41);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(360, 43);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Sort Mode:";
      // 
      // _rb_TotalHits
      // 
      this._rb_TotalHits.AutoSize = true;
      this._rb_TotalHits.Location = new System.Drawing.Point(188, 19);
      this._rb_TotalHits.Name = "_rb_TotalHits";
      this._rb_TotalHits.Size = new System.Drawing.Size(70, 17);
      this._rb_TotalHits.TabIndex = 2;
      this._rb_TotalHits.Text = "Total Hits";
      this._rb_TotalHits.UseVisualStyleBackColor = true;
      // 
      // _rb_Hits
      // 
      this._rb_Hits.AutoSize = true;
      this._rb_Hits.Location = new System.Drawing.Point(97, 19);
      this._rb_Hits.Name = "_rb_Hits";
      this._rb_Hits.Size = new System.Drawing.Size(43, 17);
      this._rb_Hits.TabIndex = 1;
      this._rb_Hits.Text = "Hits";
      this._rb_Hits.UseVisualStyleBackColor = true;
      // 
      // _rb_Radius
      // 
      this._rb_Radius.AutoSize = true;
      this._rb_Radius.Location = new System.Drawing.Point(6, 19);
      this._rb_Radius.Name = "_rb_Radius";
      this._rb_Radius.Size = new System.Drawing.Size(58, 17);
      this._rb_Radius.TabIndex = 0;
      this._rb_Radius.Text = "Radius";
      this._rb_Radius.UseVisualStyleBackColor = true;
      // 
      // _dgv
      // 
      this._dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this._dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this._dgv.Location = new System.Drawing.Point(12, 90);
      this._dgv.Name = "_dgv";
      this._dgv.Size = new System.Drawing.Size(360, 348);
      this._dgv.TabIndex = 4;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(384, 450);
      this.Controls.Add(this._dgv);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this._lbl_FrictionValue);
      this.Controls.Add(this._lbl_Friction);
      this.Controls.Add(this._btn_Table);
      this.Name = "Form1";
      this.Text = "Form1";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this._dgv)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button _btn_Table;
    private System.Windows.Forms.Label _lbl_Friction;
    private System.Windows.Forms.Label _lbl_FrictionValue;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton _rb_TotalHits;
    private System.Windows.Forms.RadioButton _rb_Hits;
    private System.Windows.Forms.RadioButton _rb_Radius;
    private System.Windows.Forms.DataGridView _dgv;
  }
}

