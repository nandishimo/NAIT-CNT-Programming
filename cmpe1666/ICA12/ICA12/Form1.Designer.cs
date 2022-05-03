
namespace ICA12
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
            this.components = new System.ComponentModel.Container();
            this.UI_TBar_NumBlocks = new System.Windows.Forms.TrackBar();
            this.UI_lbl_numBlocks = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.UI_btn_Generate = new System.Windows.Forms.Button();
            this.UI_btn_FillColor = new System.Windows.Forms.Button();
            this.UI_btn_Fill = new System.Windows.Forms.Button();
            this.UI_lbl_FillColor = new System.Windows.Forms.Label();
            this.UI_lbl_displayColor = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UI_TBar_NumBlocks)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_TBar_NumBlocks
            // 
            this.UI_TBar_NumBlocks.Location = new System.Drawing.Point(25, 42);
            this.UI_TBar_NumBlocks.Maximum = 3000;
            this.UI_TBar_NumBlocks.Minimum = 10;
            this.UI_TBar_NumBlocks.Name = "UI_TBar_NumBlocks";
            this.UI_TBar_NumBlocks.Size = new System.Drawing.Size(437, 45);
            this.UI_TBar_NumBlocks.TabIndex = 0;
            this.UI_TBar_NumBlocks.TickFrequency = 100;
            this.UI_TBar_NumBlocks.Value = 10;
            // 
            // UI_lbl_numBlocks
            // 
            this.UI_lbl_numBlocks.AutoSize = true;
            this.UI_lbl_numBlocks.Location = new System.Drawing.Point(202, 26);
            this.UI_lbl_numBlocks.Name = "UI_lbl_numBlocks";
            this.UI_lbl_numBlocks.Size = new System.Drawing.Size(91, 13);
            this.UI_lbl_numBlocks.TabIndex = 1;
            this.UI_lbl_numBlocks.Text = "Number of Blocks";
            // 
            // UI_btn_Generate
            // 
            this.UI_btn_Generate.Location = new System.Drawing.Point(78, 159);
            this.UI_btn_Generate.Name = "UI_btn_Generate";
            this.UI_btn_Generate.Size = new System.Drawing.Size(110, 31);
            this.UI_btn_Generate.TabIndex = 2;
            this.UI_btn_Generate.Text = "Generate";
            this.UI_btn_Generate.UseVisualStyleBackColor = true;
            this.UI_btn_Generate.Click += new System.EventHandler(this.UI_btn_Generate_Click);
            // 
            // UI_btn_FillColor
            // 
            this.UI_btn_FillColor.Location = new System.Drawing.Point(194, 159);
            this.UI_btn_FillColor.Name = "UI_btn_FillColor";
            this.UI_btn_FillColor.Size = new System.Drawing.Size(110, 31);
            this.UI_btn_FillColor.TabIndex = 3;
            this.UI_btn_FillColor.Text = "Fill Color";
            this.UI_btn_FillColor.UseVisualStyleBackColor = true;
            this.UI_btn_FillColor.Click += new System.EventHandler(this.UI_btn_FillColor_Click);
            // 
            // UI_btn_Fill
            // 
            this.UI_btn_Fill.Location = new System.Drawing.Point(310, 159);
            this.UI_btn_Fill.Name = "UI_btn_Fill";
            this.UI_btn_Fill.Size = new System.Drawing.Size(110, 31);
            this.UI_btn_Fill.TabIndex = 4;
            this.UI_btn_Fill.Text = "Fill";
            this.UI_btn_Fill.UseVisualStyleBackColor = true;
            this.UI_btn_Fill.Click += new System.EventHandler(this.UI_btn_Fill_Click);
            // 
            // UI_lbl_FillColor
            // 
            this.UI_lbl_FillColor.AutoSize = true;
            this.UI_lbl_FillColor.Location = new System.Drawing.Point(126, 110);
            this.UI_lbl_FillColor.Name = "UI_lbl_FillColor";
            this.UI_lbl_FillColor.Size = new System.Drawing.Size(46, 13);
            this.UI_lbl_FillColor.TabIndex = 5;
            this.UI_lbl_FillColor.Text = "Fill Color";
            // 
            // UI_lbl_displayColor
            // 
            this.UI_lbl_displayColor.AutoSize = true;
            this.UI_lbl_displayColor.BackColor = System.Drawing.Color.Black;
            this.UI_lbl_displayColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UI_lbl_displayColor.Location = new System.Drawing.Point(222, 90);
            this.UI_lbl_displayColor.MinimumSize = new System.Drawing.Size(50, 50);
            this.UI_lbl_displayColor.Name = "UI_lbl_displayColor";
            this.UI_lbl_displayColor.Size = new System.Drawing.Size(50, 50);
            this.UI_lbl_displayColor.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 215);
            this.Controls.Add(this.UI_lbl_displayColor);
            this.Controls.Add(this.UI_lbl_FillColor);
            this.Controls.Add(this.UI_btn_Fill);
            this.Controls.Add(this.UI_btn_FillColor);
            this.Controls.Add(this.UI_btn_Generate);
            this.Controls.Add(this.UI_lbl_numBlocks);
            this.Controls.Add(this.UI_TBar_NumBlocks);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UI_TBar_NumBlocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar UI_TBar_NumBlocks;
        private System.Windows.Forms.Label UI_lbl_numBlocks;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button UI_btn_Generate;
        private System.Windows.Forms.Button UI_btn_FillColor;
        private System.Windows.Forms.Button UI_btn_Fill;
        private System.Windows.Forms.Label UI_lbl_FillColor;
        private System.Windows.Forms.Label UI_lbl_displayColor;
        private System.Windows.Forms.Timer timer1;
    }
}

