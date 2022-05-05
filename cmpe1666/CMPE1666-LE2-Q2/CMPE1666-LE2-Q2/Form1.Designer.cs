
namespace CMPE1666_LE2_Q2
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
            this.UI_cb_ShowModeless = new System.Windows.Forms.CheckBox();
            this.UI_tb_Result = new System.Windows.Forms.TextBox();
            this.UI_lbl_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_cb_ShowModeless
            // 
            this.UI_cb_ShowModeless.AutoSize = true;
            this.UI_cb_ShowModeless.Location = new System.Drawing.Point(88, 64);
            this.UI_cb_ShowModeless.Name = "UI_cb_ShowModeless";
            this.UI_cb_ShowModeless.Size = new System.Drawing.Size(98, 17);
            this.UI_cb_ShowModeless.TabIndex = 0;
            this.UI_cb_ShowModeless.Text = "ShowModeless";
            this.UI_cb_ShowModeless.UseVisualStyleBackColor = true;
            this.UI_cb_ShowModeless.CheckedChanged += new System.EventHandler(this.UI_cb_ShowModeless_CheckedChanged);
            // 
            // UI_tb_Result
            // 
            this.UI_tb_Result.Location = new System.Drawing.Point(102, 153);
            this.UI_tb_Result.Name = "UI_tb_Result";
            this.UI_tb_Result.ReadOnly = true;
            this.UI_tb_Result.Size = new System.Drawing.Size(168, 20);
            this.UI_tb_Result.TabIndex = 1;
            // 
            // UI_lbl_Result
            // 
            this.UI_lbl_Result.AutoSize = true;
            this.UI_lbl_Result.Location = new System.Drawing.Point(56, 156);
            this.UI_lbl_Result.Name = "UI_lbl_Result";
            this.UI_lbl_Result.Size = new System.Drawing.Size(40, 13);
            this.UI_lbl_Result.TabIndex = 2;
            this.UI_lbl_Result.Text = "Result:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 185);
            this.Controls.Add(this.UI_lbl_Result);
            this.Controls.Add(this.UI_tb_Result);
            this.Controls.Add(this.UI_cb_ShowModeless);
            this.Name = "Form1";
            this.Text = "Question 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox UI_cb_ShowModeless;
        private System.Windows.Forms.TextBox UI_tb_Result;
        private System.Windows.Forms.Label UI_lbl_Result;
    }
}

