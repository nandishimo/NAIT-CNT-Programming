
namespace Lab03
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
            this.UI_cb_ShowScore = new System.Windows.Forms.CheckBox();
            this.UI_cb_ShowSpeed = new System.Windows.Forms.CheckBox();
            this.UI_btn_Play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_cb_ShowScore
            // 
            this.UI_cb_ShowScore.AutoSize = true;
            this.UI_cb_ShowScore.Location = new System.Drawing.Point(61, 27);
            this.UI_cb_ShowScore.Name = "UI_cb_ShowScore";
            this.UI_cb_ShowScore.Size = new System.Drawing.Size(84, 17);
            this.UI_cb_ShowScore.TabIndex = 0;
            this.UI_cb_ShowScore.Text = "Show Score";
            this.UI_cb_ShowScore.UseVisualStyleBackColor = true;
            // 
            // UI_cb_ShowSpeed
            // 
            this.UI_cb_ShowSpeed.AutoSize = true;
            this.UI_cb_ShowSpeed.Location = new System.Drawing.Point(61, 50);
            this.UI_cb_ShowSpeed.Name = "UI_cb_ShowSpeed";
            this.UI_cb_ShowSpeed.Size = new System.Drawing.Size(136, 17);
            this.UI_cb_ShowSpeed.TabIndex = 1;
            this.UI_cb_ShowSpeed.Text = "Show Animation Speed";
            this.UI_cb_ShowSpeed.UseVisualStyleBackColor = true;
            // 
            // UI_btn_Play
            // 
            this.UI_btn_Play.Location = new System.Drawing.Point(128, 87);
            this.UI_btn_Play.Name = "UI_btn_Play";
            this.UI_btn_Play.Size = new System.Drawing.Size(99, 28);
            this.UI_btn_Play.TabIndex = 2;
            this.UI_btn_Play.Text = "Play";
            this.UI_btn_Play.UseVisualStyleBackColor = true;
            this.UI_btn_Play.Click += new System.EventHandler(this.UI_btn_Play_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 140);
            this.Controls.Add(this.UI_btn_Play);
            this.Controls.Add(this.UI_cb_ShowSpeed);
            this.Controls.Add(this.UI_cb_ShowScore);
            this.Name = "Form1";
            this.Text = "Lab 3 - Ballz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox UI_cb_ShowScore;
        private System.Windows.Forms.CheckBox UI_cb_ShowSpeed;
        private System.Windows.Forms.Button UI_btn_Play;
    }
}

