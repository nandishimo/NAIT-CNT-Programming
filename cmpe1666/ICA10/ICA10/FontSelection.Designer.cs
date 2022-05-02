
namespace ICA10
{
    partial class FontSelection
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
            this.UI_btn_font = new System.Windows.Forms.Button();
            this.UI_btn_colour = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.UI_font_tbx = new System.Windows.Forms.TextBox();
            this.UI_colour_tbx = new System.Windows.Forms.TextBox();
            this.UI_btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_btn_font
            // 
            this.UI_btn_font.Location = new System.Drawing.Point(12, 12);
            this.UI_btn_font.Name = "UI_btn_font";
            this.UI_btn_font.Size = new System.Drawing.Size(125, 26);
            this.UI_btn_font.TabIndex = 0;
            this.UI_btn_font.Text = "Select Font";
            this.UI_btn_font.UseVisualStyleBackColor = true;
            this.UI_btn_font.Click += new System.EventHandler(this.UI_btn_font_Click);
            // 
            // UI_btn_colour
            // 
            this.UI_btn_colour.Location = new System.Drawing.Point(12, 44);
            this.UI_btn_colour.Name = "UI_btn_colour";
            this.UI_btn_colour.Size = new System.Drawing.Size(125, 28);
            this.UI_btn_colour.TabIndex = 1;
            this.UI_btn_colour.Text = "Select Colour";
            this.UI_btn_colour.UseVisualStyleBackColor = true;
            this.UI_btn_colour.Click += new System.EventHandler(this.UI_btn_colour_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // UI_font_tbx
            // 
            this.UI_font_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_font_tbx.Location = new System.Drawing.Point(143, 12);
            this.UI_font_tbx.Name = "UI_font_tbx";
            this.UI_font_tbx.ReadOnly = true;
            this.UI_font_tbx.Size = new System.Drawing.Size(413, 26);
            this.UI_font_tbx.TabIndex = 2;
            this.UI_font_tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UI_colour_tbx
            // 
            this.UI_colour_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_colour_tbx.Location = new System.Drawing.Point(143, 46);
            this.UI_colour_tbx.Name = "UI_colour_tbx";
            this.UI_colour_tbx.ReadOnly = true;
            this.UI_colour_tbx.Size = new System.Drawing.Size(413, 26);
            this.UI_colour_tbx.TabIndex = 3;
            this.UI_colour_tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UI_btn_OK
            // 
            this.UI_btn_OK.Location = new System.Drawing.Point(227, 78);
            this.UI_btn_OK.Name = "UI_btn_OK";
            this.UI_btn_OK.Size = new System.Drawing.Size(125, 28);
            this.UI_btn_OK.TabIndex = 4;
            this.UI_btn_OK.Text = "OK";
            this.UI_btn_OK.UseVisualStyleBackColor = true;
            this.UI_btn_OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // FontSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 117);
            this.Controls.Add(this.UI_btn_OK);
            this.Controls.Add(this.UI_colour_tbx);
            this.Controls.Add(this.UI_font_tbx);
            this.Controls.Add(this.UI_btn_colour);
            this.Controls.Add(this.UI_btn_font);
            this.Name = "FontSelection";
            this.Text = "FontSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_btn_font;
        private System.Windows.Forms.Button UI_btn_colour;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox UI_font_tbx;
        private System.Windows.Forms.TextBox UI_colour_tbx;
        private System.Windows.Forms.Button UI_btn_OK;
    }
}