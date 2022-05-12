
namespace Lab03
{
    partial class ModalDialog
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
            this.groupBox_Difficulty = new System.Windows.Forms.GroupBox();
            this.UI_rb_Easy = new System.Windows.Forms.RadioButton();
            this.UI_rb_Medium = new System.Windows.Forms.RadioButton();
            this.UI_rb_Hard = new System.Windows.Forms.RadioButton();
            this.UI_btn_OK = new System.Windows.Forms.Button();
            this.UI_btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox_Difficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Difficulty
            // 
            this.groupBox_Difficulty.Controls.Add(this.UI_rb_Hard);
            this.groupBox_Difficulty.Controls.Add(this.UI_rb_Medium);
            this.groupBox_Difficulty.Controls.Add(this.UI_rb_Easy);
            this.groupBox_Difficulty.Location = new System.Drawing.Point(18, 12);
            this.groupBox_Difficulty.Name = "groupBox_Difficulty";
            this.groupBox_Difficulty.Size = new System.Drawing.Size(141, 101);
            this.groupBox_Difficulty.TabIndex = 0;
            this.groupBox_Difficulty.TabStop = false;
            this.groupBox_Difficulty.Text = "Difficulty";
            // 
            // UI_rb_Easy
            // 
            this.UI_rb_Easy.AutoSize = true;
            this.UI_rb_Easy.Checked = true;
            this.UI_rb_Easy.Location = new System.Drawing.Point(6, 19);
            this.UI_rb_Easy.Name = "UI_rb_Easy";
            this.UI_rb_Easy.Size = new System.Drawing.Size(48, 17);
            this.UI_rb_Easy.TabIndex = 0;
            this.UI_rb_Easy.TabStop = true;
            this.UI_rb_Easy.Text = "Easy";
            this.UI_rb_Easy.UseVisualStyleBackColor = true;
            // 
            // UI_rb_Medium
            // 
            this.UI_rb_Medium.AutoSize = true;
            this.UI_rb_Medium.Location = new System.Drawing.Point(6, 42);
            this.UI_rb_Medium.Name = "UI_rb_Medium";
            this.UI_rb_Medium.Size = new System.Drawing.Size(62, 17);
            this.UI_rb_Medium.TabIndex = 1;
            this.UI_rb_Medium.Text = "Medium";
            this.UI_rb_Medium.UseVisualStyleBackColor = true;
            // 
            // UI_rb_Hard
            // 
            this.UI_rb_Hard.AutoSize = true;
            this.UI_rb_Hard.Location = new System.Drawing.Point(6, 65);
            this.UI_rb_Hard.Name = "UI_rb_Hard";
            this.UI_rb_Hard.Size = new System.Drawing.Size(48, 17);
            this.UI_rb_Hard.TabIndex = 2;
            this.UI_rb_Hard.Text = "Hard";
            this.UI_rb_Hard.UseVisualStyleBackColor = true;
            // 
            // UI_btn_OK
            // 
            this.UI_btn_OK.Location = new System.Drawing.Point(18, 136);
            this.UI_btn_OK.Name = "UI_btn_OK";
            this.UI_btn_OK.Size = new System.Drawing.Size(92, 35);
            this.UI_btn_OK.TabIndex = 1;
            this.UI_btn_OK.Text = "OK";
            this.UI_btn_OK.UseVisualStyleBackColor = true;
            this.UI_btn_OK.Click += new System.EventHandler(this.UI_btn_OK_Click);
            // 
            // UI_btn_Cancel
            // 
            this.UI_btn_Cancel.Location = new System.Drawing.Point(126, 136);
            this.UI_btn_Cancel.Name = "UI_btn_Cancel";
            this.UI_btn_Cancel.Size = new System.Drawing.Size(92, 35);
            this.UI_btn_Cancel.TabIndex = 2;
            this.UI_btn_Cancel.Text = "Cancel";
            this.UI_btn_Cancel.UseVisualStyleBackColor = true;
            this.UI_btn_Cancel.Click += new System.EventHandler(this.UI_btn_Cancel_Click);
            // 
            // ModalDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 186);
            this.Controls.Add(this.UI_btn_Cancel);
            this.Controls.Add(this.UI_btn_OK);
            this.Controls.Add(this.groupBox_Difficulty);
            this.Name = "ModalDialog";
            this.Text = "Select Difficulty";
            this.groupBox_Difficulty.ResumeLayout(false);
            this.groupBox_Difficulty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Difficulty;
        private System.Windows.Forms.RadioButton UI_rb_Hard;
        private System.Windows.Forms.RadioButton UI_rb_Medium;
        private System.Windows.Forms.RadioButton UI_rb_Easy;
        private System.Windows.Forms.Button UI_btn_OK;
        private System.Windows.Forms.Button UI_btn_Cancel;
    }
}