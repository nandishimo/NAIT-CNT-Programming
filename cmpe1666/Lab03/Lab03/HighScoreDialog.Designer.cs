﻿
namespace Lab03
{
    partial class HighScoreDialog
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
            this.UI_tb_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UI_btn_OK = new System.Windows.Forms.Button();
            this.UI_btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_tb_Name
            // 
            this.UI_tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_tb_Name.Location = new System.Drawing.Point(141, 31);
            this.UI_tb_Name.Name = "UI_tb_Name";
            this.UI_tb_Name.Size = new System.Drawing.Size(241, 29);
            this.UI_tb_Name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player Name:";
            // 
            // UI_btn_OK
            // 
            this.UI_btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_btn_OK.Location = new System.Drawing.Point(12, 96);
            this.UI_btn_OK.Name = "UI_btn_OK";
            this.UI_btn_OK.Size = new System.Drawing.Size(94, 42);
            this.UI_btn_OK.TabIndex = 2;
            this.UI_btn_OK.Text = "OK";
            this.UI_btn_OK.UseVisualStyleBackColor = true;
            this.UI_btn_OK.Click += new System.EventHandler(this.UI_btn_OK_Click);
            // 
            // UI_btn_Cancel
            // 
            this.UI_btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_btn_Cancel.Location = new System.Drawing.Point(288, 96);
            this.UI_btn_Cancel.Name = "UI_btn_Cancel";
            this.UI_btn_Cancel.Size = new System.Drawing.Size(94, 42);
            this.UI_btn_Cancel.TabIndex = 3;
            this.UI_btn_Cancel.Text = "Cancel";
            this.UI_btn_Cancel.UseVisualStyleBackColor = true;
            this.UI_btn_Cancel.Click += new System.EventHandler(this.UI_btn_Cancel_Click);
            // 
            // HighScoreDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 150);
            this.Controls.Add(this.UI_btn_Cancel);
            this.Controls.Add(this.UI_btn_OK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_tb_Name);
            this.Name = "HighScoreDialog";
            this.Text = "HighScoreDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_tb_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UI_btn_OK;
        private System.Windows.Forms.Button UI_btn_Cancel;
    }
}