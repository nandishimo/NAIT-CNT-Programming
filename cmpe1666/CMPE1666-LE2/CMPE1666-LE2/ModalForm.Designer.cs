
namespace CMPE1666_LE2
{
    partial class ModalForm
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
            this.UI_btn_OK = new System.Windows.Forms.Button();
            this.UI_btn_Cancel = new System.Windows.Forms.Button();
            this.UI_tb_NameEntry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UI_btn_OK
            // 
            this.UI_btn_OK.Location = new System.Drawing.Point(66, 167);
            this.UI_btn_OK.Name = "UI_btn_OK";
            this.UI_btn_OK.Size = new System.Drawing.Size(91, 28);
            this.UI_btn_OK.TabIndex = 0;
            this.UI_btn_OK.Text = "OK";
            this.UI_btn_OK.UseVisualStyleBackColor = true;
            this.UI_btn_OK.Click += new System.EventHandler(this.UI_btn_OK_Click);
            // 
            // UI_btn_Cancel
            // 
            this.UI_btn_Cancel.Location = new System.Drawing.Point(188, 167);
            this.UI_btn_Cancel.Name = "UI_btn_Cancel";
            this.UI_btn_Cancel.Size = new System.Drawing.Size(91, 28);
            this.UI_btn_Cancel.TabIndex = 1;
            this.UI_btn_Cancel.Text = "Cancel";
            this.UI_btn_Cancel.UseVisualStyleBackColor = true;
            this.UI_btn_Cancel.Click += new System.EventHandler(this.UI_btn_Cancel_Click);
            // 
            // UI_tb_NameEntry
            // 
            this.UI_tb_NameEntry.Location = new System.Drawing.Point(62, 76);
            this.UI_tb_NameEntry.Name = "UI_tb_NameEntry";
            this.UI_tb_NameEntry.Size = new System.Drawing.Size(217, 20);
            this.UI_tb_NameEntry.TabIndex = 2;
            // 
            // ModalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 226);
            this.Controls.Add(this.UI_tb_NameEntry);
            this.Controls.Add(this.UI_btn_Cancel);
            this.Controls.Add(this.UI_btn_OK);
            this.Name = "ModalForm";
            this.Text = "Add Name";
            this.Load += new System.EventHandler(this.ModalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_btn_OK;
        private System.Windows.Forms.Button UI_btn_Cancel;
        private System.Windows.Forms.TextBox UI_tb_NameEntry;
    }
}