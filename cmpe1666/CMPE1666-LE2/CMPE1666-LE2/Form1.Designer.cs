
namespace CMPE1666_LE2
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
            this.UI_btn_AddName = new System.Windows.Forms.Button();
            this.UI_lb_NameList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // UI_btn_AddName
            // 
            this.UI_btn_AddName.Location = new System.Drawing.Point(45, 98);
            this.UI_btn_AddName.Name = "UI_btn_AddName";
            this.UI_btn_AddName.Size = new System.Drawing.Size(80, 29);
            this.UI_btn_AddName.TabIndex = 0;
            this.UI_btn_AddName.Text = "Add Name";
            this.UI_btn_AddName.UseVisualStyleBackColor = true;
            this.UI_btn_AddName.Click += new System.EventHandler(this.UI_btn_AddName_Click);
            // 
            // UI_lb_NameList
            // 
            this.UI_lb_NameList.FormattingEnabled = true;
            this.UI_lb_NameList.Location = new System.Drawing.Point(157, 68);
            this.UI_lb_NameList.Name = "UI_lb_NameList";
            this.UI_lb_NameList.Size = new System.Drawing.Size(151, 108);
            this.UI_lb_NameList.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 202);
            this.Controls.Add(this.UI_lb_NameList);
            this.Controls.Add(this.UI_btn_AddName);
            this.Name = "Form1";
            this.Text = "Question 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UI_btn_AddName;
        private System.Windows.Forms.ListBox UI_lb_NameList;
    }
}

