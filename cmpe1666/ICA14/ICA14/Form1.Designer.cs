
namespace ICA14
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
            this.UI_lb_Text = new System.Windows.Forms.ListBox();
            this.UI_btn_Go = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UI_lb_Text
            // 
            this.UI_lb_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_lb_Text.FormattingEnabled = true;
            this.UI_lb_Text.Location = new System.Drawing.Point(12, 12);
            this.UI_lb_Text.Name = "UI_lb_Text";
            this.UI_lb_Text.Size = new System.Drawing.Size(776, 381);
            this.UI_lb_Text.TabIndex = 0;
            // 
            // UI_btn_Go
            // 
            this.UI_btn_Go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_btn_Go.Location = new System.Drawing.Point(693, 409);
            this.UI_btn_Go.Name = "UI_btn_Go";
            this.UI_btn_Go.Size = new System.Drawing.Size(95, 29);
            this.UI_btn_Go.TabIndex = 1;
            this.UI_btn_Go.Text = "Go!";
            this.UI_btn_Go.UseVisualStyleBackColor = true;
            this.UI_btn_Go.Click += new System.EventHandler(this.UI_btn_Go_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "All File (Images) | *.*";
            this.openFileDialog1.Multiselect = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_btn_Go);
            this.Controls.Add(this.UI_lb_Text);
            this.Name = "Form1";
            this.Text = "Image Scanner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox UI_lb_Text;
        private System.Windows.Forms.Button UI_btn_Go;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}

