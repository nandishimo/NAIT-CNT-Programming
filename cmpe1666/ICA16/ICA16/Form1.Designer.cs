
namespace ICA16
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
            this.UI_TB_Queue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UI_TB_Queue
            // 
            this.UI_TB_Queue.Location = new System.Drawing.Point(12, 15);
            this.UI_TB_Queue.Name = "UI_TB_Queue";
            this.UI_TB_Queue.ReadOnly = true;
            this.UI_TB_Queue.Size = new System.Drawing.Size(775, 20);
            this.UI_TB_Queue.TabIndex = 0;
            this.UI_TB_Queue.Text = "0 segs in queue. Estimated time to draw: 0.00 seconds";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 53);
            this.Controls.Add(this.UI_TB_Queue);
            this.Name = "Form1";
            this.Text = "ICA 16 - Slow Draw";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UI_TB_Queue;
    }
}

