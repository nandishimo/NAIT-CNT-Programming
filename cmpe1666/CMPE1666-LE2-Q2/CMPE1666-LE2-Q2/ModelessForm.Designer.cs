
namespace CMPE1666_LE2_Q2
{
    partial class ModelessForm
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
            this.UI_lbl_Value1 = new System.Windows.Forms.Label();
            this.UI_lbl_Value2 = new System.Windows.Forms.Label();
            this.UI_tb_Value1 = new System.Windows.Forms.TextBox();
            this.UI_tb_Value2 = new System.Windows.Forms.TextBox();
            this.Operations_GroupBox = new System.Windows.Forms.GroupBox();
            this.UI_rb_Multiplication = new System.Windows.Forms.RadioButton();
            this.UI_rb_Subtraction = new System.Windows.Forms.RadioButton();
            this.UI_rb_Addition = new System.Windows.Forms.RadioButton();
            this.Operations_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_lbl_Value1
            // 
            this.UI_lbl_Value1.AutoSize = true;
            this.UI_lbl_Value1.Location = new System.Drawing.Point(41, 38);
            this.UI_lbl_Value1.Name = "UI_lbl_Value1";
            this.UI_lbl_Value1.Size = new System.Drawing.Size(46, 13);
            this.UI_lbl_Value1.TabIndex = 0;
            this.UI_lbl_Value1.Text = "Value 1:";
            // 
            // UI_lbl_Value2
            // 
            this.UI_lbl_Value2.AutoSize = true;
            this.UI_lbl_Value2.Location = new System.Drawing.Point(41, 94);
            this.UI_lbl_Value2.Name = "UI_lbl_Value2";
            this.UI_lbl_Value2.Size = new System.Drawing.Size(46, 13);
            this.UI_lbl_Value2.TabIndex = 1;
            this.UI_lbl_Value2.Text = "Value 2:";
            // 
            // UI_tb_Value1
            // 
            this.UI_tb_Value1.Location = new System.Drawing.Point(93, 35);
            this.UI_tb_Value1.Name = "UI_tb_Value1";
            this.UI_tb_Value1.Size = new System.Drawing.Size(353, 20);
            this.UI_tb_Value1.TabIndex = 2;
            this.UI_tb_Value1.TextChanged += new System.EventHandler(this.UI_rb_CheckedChanged);
            // 
            // UI_tb_Value2
            // 
            this.UI_tb_Value2.Location = new System.Drawing.Point(93, 91);
            this.UI_tb_Value2.Name = "UI_tb_Value2";
            this.UI_tb_Value2.Size = new System.Drawing.Size(353, 20);
            this.UI_tb_Value2.TabIndex = 3;
            this.UI_tb_Value2.TextChanged += new System.EventHandler(this.UI_rb_CheckedChanged);
            // 
            // Operations_GroupBox
            // 
            this.Operations_GroupBox.Controls.Add(this.UI_rb_Multiplication);
            this.Operations_GroupBox.Controls.Add(this.UI_rb_Subtraction);
            this.Operations_GroupBox.Controls.Add(this.UI_rb_Addition);
            this.Operations_GroupBox.Location = new System.Drawing.Point(147, 132);
            this.Operations_GroupBox.Name = "Operations_GroupBox";
            this.Operations_GroupBox.Size = new System.Drawing.Size(171, 110);
            this.Operations_GroupBox.TabIndex = 4;
            this.Operations_GroupBox.TabStop = false;
            this.Operations_GroupBox.Text = "Operation";
            // 
            // UI_rb_Multiplication
            // 
            this.UI_rb_Multiplication.AutoSize = true;
            this.UI_rb_Multiplication.Location = new System.Drawing.Point(20, 74);
            this.UI_rb_Multiplication.Name = "UI_rb_Multiplication";
            this.UI_rb_Multiplication.Size = new System.Drawing.Size(86, 17);
            this.UI_rb_Multiplication.TabIndex = 2;
            this.UI_rb_Multiplication.TabStop = true;
            this.UI_rb_Multiplication.Text = "Multiplication";
            this.UI_rb_Multiplication.UseVisualStyleBackColor = true;
            this.UI_rb_Multiplication.CheckedChanged += new System.EventHandler(this.UI_rb_CheckedChanged);
            // 
            // UI_rb_Subtraction
            // 
            this.UI_rb_Subtraction.AutoSize = true;
            this.UI_rb_Subtraction.Location = new System.Drawing.Point(20, 51);
            this.UI_rb_Subtraction.Name = "UI_rb_Subtraction";
            this.UI_rb_Subtraction.Size = new System.Drawing.Size(79, 17);
            this.UI_rb_Subtraction.TabIndex = 1;
            this.UI_rb_Subtraction.TabStop = true;
            this.UI_rb_Subtraction.Text = "Subtraction";
            this.UI_rb_Subtraction.UseVisualStyleBackColor = true;
            this.UI_rb_Subtraction.CheckedChanged += new System.EventHandler(this.UI_rb_CheckedChanged);
            // 
            // UI_rb_Addition
            // 
            this.UI_rb_Addition.AutoSize = true;
            this.UI_rb_Addition.Checked = true;
            this.UI_rb_Addition.Location = new System.Drawing.Point(20, 28);
            this.UI_rb_Addition.Name = "UI_rb_Addition";
            this.UI_rb_Addition.Size = new System.Drawing.Size(63, 17);
            this.UI_rb_Addition.TabIndex = 0;
            this.UI_rb_Addition.TabStop = true;
            this.UI_rb_Addition.Text = "Addition";
            this.UI_rb_Addition.UseVisualStyleBackColor = true;
            this.UI_rb_Addition.CheckedChanged += new System.EventHandler(this.UI_rb_CheckedChanged);
            // 
            // ModelessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 259);
            this.Controls.Add(this.Operations_GroupBox);
            this.Controls.Add(this.UI_tb_Value2);
            this.Controls.Add(this.UI_tb_Value1);
            this.Controls.Add(this.UI_lbl_Value2);
            this.Controls.Add(this.UI_lbl_Value1);
            this.Name = "ModelessForm";
            this.Text = "ModelessForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelessForm_FormClosing);
            this.Operations_GroupBox.ResumeLayout(false);
            this.Operations_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_lbl_Value1;
        private System.Windows.Forms.Label UI_lbl_Value2;
        private System.Windows.Forms.TextBox UI_tb_Value1;
        private System.Windows.Forms.TextBox UI_tb_Value2;
        private System.Windows.Forms.GroupBox Operations_GroupBox;
        private System.Windows.Forms.RadioButton UI_rb_Multiplication;
        private System.Windows.Forms.RadioButton UI_rb_Subtraction;
        private System.Windows.Forms.RadioButton UI_rb_Addition;
    }
}