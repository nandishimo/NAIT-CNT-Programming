
namespace ICA13
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
            this.UI_Load_btn = new System.Windows.Forms.Button();
            this.UI_Find_btn = new System.Windows.Forms.Button();
            this.UI_Loaded_TB = new System.Windows.Forms.TextBox();
            this.UI_Test_TB = new System.Windows.Forms.TextBox();
            this.UI_Test_btn = new System.Windows.Forms.Button();
            this.UI_OFD = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // UI_Load_btn
            // 
            this.UI_Load_btn.Location = new System.Drawing.Point(12, 12);
            this.UI_Load_btn.Name = "UI_Load_btn";
            this.UI_Load_btn.Size = new System.Drawing.Size(105, 34);
            this.UI_Load_btn.TabIndex = 0;
            this.UI_Load_btn.Text = "Load File";
            this.UI_Load_btn.UseVisualStyleBackColor = true;
            this.UI_Load_btn.Click += new System.EventHandler(this.UI_Load_btn_Click);
            // 
            // UI_Find_btn
            // 
            this.UI_Find_btn.Location = new System.Drawing.Point(123, 12);
            this.UI_Find_btn.Name = "UI_Find_btn";
            this.UI_Find_btn.Size = new System.Drawing.Size(105, 34);
            this.UI_Find_btn.TabIndex = 1;
            this.UI_Find_btn.Text = "Find";
            this.UI_Find_btn.UseVisualStyleBackColor = true;
            this.UI_Find_btn.Click += new System.EventHandler(this.UI_Find_btn_Click);
            // 
            // UI_Loaded_TB
            // 
            this.UI_Loaded_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Loaded_TB.Location = new System.Drawing.Point(12, 52);
            this.UI_Loaded_TB.Multiline = true;
            this.UI_Loaded_TB.Name = "UI_Loaded_TB";
            this.UI_Loaded_TB.Size = new System.Drawing.Size(776, 386);
            this.UI_Loaded_TB.TabIndex = 2;
            // 
            // UI_Test_TB
            // 
            this.UI_Test_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Test_TB.Location = new System.Drawing.Point(448, 15);
            this.UI_Test_TB.Name = "UI_Test_TB";
            this.UI_Test_TB.Size = new System.Drawing.Size(229, 26);
            this.UI_Test_TB.TabIndex = 3;
            // 
            // UI_Test_btn
            // 
            this.UI_Test_btn.Location = new System.Drawing.Point(683, 12);
            this.UI_Test_btn.Name = "UI_Test_btn";
            this.UI_Test_btn.Size = new System.Drawing.Size(105, 34);
            this.UI_Test_btn.TabIndex = 4;
            this.UI_Test_btn.Text = "Sample Test";
            this.UI_Test_btn.UseVisualStyleBackColor = true;
            this.UI_Test_btn.Click += new System.EventHandler(this.UI_Test_btn_Click);
            // 
            // UI_OFD
            // 
            this.UI_OFD.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Test_btn);
            this.Controls.Add(this.UI_Test_TB);
            this.Controls.Add(this.UI_Loaded_TB);
            this.Controls.Add(this.UI_Find_btn);
            this.Controls.Add(this.UI_Load_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_Load_btn;
        private System.Windows.Forms.Button UI_Find_btn;
        private System.Windows.Forms.TextBox UI_Loaded_TB;
        private System.Windows.Forms.TextBox UI_Test_TB;
        private System.Windows.Forms.Button UI_Test_btn;
        private System.Windows.Forms.OpenFileDialog UI_OFD;
    }
}

