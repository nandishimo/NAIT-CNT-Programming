
namespace LabExam1Q3
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
            this.UI_RawData_LB = new System.Windows.Forms.ListBox();
            this.UI_SortedData_LB = new System.Windows.Forms.ListBox();
            this.UI_LoadProvidedData_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UI_SortProvidedData_btn = new System.Windows.Forms.Button();
            this.UI_SortByID_Radio = new System.Windows.Forms.RadioButton();
            this.UI_SortByTemp_Radio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_RawData_LB
            // 
            this.UI_RawData_LB.FormattingEnabled = true;
            this.UI_RawData_LB.Location = new System.Drawing.Point(97, 28);
            this.UI_RawData_LB.Name = "UI_RawData_LB";
            this.UI_RawData_LB.Size = new System.Drawing.Size(228, 420);
            this.UI_RawData_LB.TabIndex = 0;
            // 
            // UI_SortedData_LB
            // 
            this.UI_SortedData_LB.FormattingEnabled = true;
            this.UI_SortedData_LB.Location = new System.Drawing.Point(704, 28);
            this.UI_SortedData_LB.Name = "UI_SortedData_LB";
            this.UI_SortedData_LB.Size = new System.Drawing.Size(228, 420);
            this.UI_SortedData_LB.TabIndex = 1;
            // 
            // UI_LoadProvidedData_Btn
            // 
            this.UI_LoadProvidedData_Btn.Location = new System.Drawing.Point(420, 85);
            this.UI_LoadProvidedData_Btn.Name = "UI_LoadProvidedData_Btn";
            this.UI_LoadProvidedData_Btn.Size = new System.Drawing.Size(189, 55);
            this.UI_LoadProvidedData_Btn.TabIndex = 2;
            this.UI_LoadProvidedData_Btn.Text = "Load Data";
            this.UI_LoadProvidedData_Btn.UseVisualStyleBackColor = true;
            this.UI_LoadProvidedData_Btn.Click += new System.EventHandler(this.UI_LoadProvidedData_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Raw Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(767, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sorted Data";
            // 
            // UI_SortProvidedData_btn
            // 
            this.UI_SortProvidedData_btn.Location = new System.Drawing.Point(420, 315);
            this.UI_SortProvidedData_btn.Name = "UI_SortProvidedData_btn";
            this.UI_SortProvidedData_btn.Size = new System.Drawing.Size(189, 55);
            this.UI_SortProvidedData_btn.TabIndex = 5;
            this.UI_SortProvidedData_btn.Text = "Sort Data";
            this.UI_SortProvidedData_btn.UseVisualStyleBackColor = true;
            this.UI_SortProvidedData_btn.Click += new System.EventHandler(this.UI_SortProvidedData_btn_Click);
            // 
            // UI_SortByID_Radio
            // 
            this.UI_SortByID_Radio.AutoSize = true;
            this.UI_SortByID_Radio.Checked = true;
            this.UI_SortByID_Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_SortByID_Radio.Location = new System.Drawing.Point(15, 35);
            this.UI_SortByID_Radio.Name = "UI_SortByID_Radio";
            this.UI_SortByID_Radio.Size = new System.Drawing.Size(148, 19);
            this.UI_SortByID_Radio.TabIndex = 8;
            this.UI_SortByID_Radio.TabStop = true;
            this.UI_SortByID_Radio.Text = "Sort By Sensor Id (Asc)";
            this.UI_SortByID_Radio.UseVisualStyleBackColor = true;
            // 
            // UI_SortByTemp_Radio
            // 
            this.UI_SortByTemp_Radio.AutoSize = true;
            this.UI_SortByTemp_Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_SortByTemp_Radio.Location = new System.Drawing.Point(15, 61);
            this.UI_SortByTemp_Radio.Name = "UI_SortByTemp_Radio";
            this.UI_SortByTemp_Radio.Size = new System.Drawing.Size(176, 19);
            this.UI_SortByTemp_Radio.TabIndex = 9;
            this.UI_SortByTemp_Radio.Text = "Sort By Temperature (Desc)";
            this.UI_SortByTemp_Radio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UI_SortByID_Radio);
            this.groupBox1.Controls.Add(this.UI_SortByTemp_Radio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(420, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 87);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorting Method";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 475);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UI_SortProvidedData_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_LoadProvidedData_Btn);
            this.Controls.Add(this.UI_SortedData_LB);
            this.Controls.Add(this.UI_RawData_LB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UI_RawData_LB;
        private System.Windows.Forms.ListBox UI_SortedData_LB;
        private System.Windows.Forms.Button UI_LoadProvidedData_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UI_SortProvidedData_btn;
        private System.Windows.Forms.RadioButton UI_SortByID_Radio;
        private System.Windows.Forms.RadioButton UI_SortByTemp_Radio;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

