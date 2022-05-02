
namespace ICA10
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
            this.UI_lbl_displayfont = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_lbl_displayfont
            // 
            this.UI_lbl_displayfont.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_lbl_displayfont.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_lbl_displayfont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UI_lbl_displayfont.Location = new System.Drawing.Point(12, 9);
            this.UI_lbl_displayfont.MinimumSize = new System.Drawing.Size(100, 100);
            this.UI_lbl_displayfont.Name = "UI_lbl_displayfont";
            this.UI_lbl_displayfont.Size = new System.Drawing.Size(380, 273);
            this.UI_lbl_displayfont.TabIndex = 0;
            this.UI_lbl_displayfont.Text = "This is the selected font!";
            this.UI_lbl_displayfont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UI_lbl_displayfont.Click += new System.EventHandler(this.UI_lbl_displayfont_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 291);
            this.Controls.Add(this.UI_lbl_displayfont);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UI_lbl_displayfont;
    }
}

