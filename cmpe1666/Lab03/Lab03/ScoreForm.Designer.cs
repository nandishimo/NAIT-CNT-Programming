
namespace Lab03
{
    partial class ScoreForm
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
            this.UI_lbl_Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_lbl_Score
            // 
            this.UI_lbl_Score.AutoSize = true;
            this.UI_lbl_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_lbl_Score.Location = new System.Drawing.Point(41, 52);
            this.UI_lbl_Score.Name = "UI_lbl_Score";
            this.UI_lbl_Score.Size = new System.Drawing.Size(139, 25);
            this.UI_lbl_Score.TabIndex = 0;
            this.UI_lbl_Score.Text = "Score: 0000";
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 129);
            this.Controls.Add(this.UI_lbl_Score);
            this.Name = "ScoreForm";
            this.Text = "Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_lbl_Score;
    }
}