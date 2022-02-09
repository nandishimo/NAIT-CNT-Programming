
namespace LabExam1Q2
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
            this.UI_Display_Tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UI_NumValues_Tbx = new System.Windows.Forms.TextBox();
            this.UI_LowerLimit_Tbx = new System.Windows.Forms.TextBox();
            this.UI_UpperLimit_Tbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UI_GenerateValues_Btn = new System.Windows.Forms.Button();
            this.UI_CalculateScore_Btn = new System.Windows.Forms.Button();
            this.UI_LoadData_Btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.UI_DataSet1_Radio = new System.Windows.Forms.RadioButton();
            this.UI_DataSet2_Radio = new System.Windows.Forms.RadioButton();
            this.UI_DataSet3_Radio = new System.Windows.Forms.RadioButton();
            this.UI_Score_Tbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UI_Display_Tbx
            // 
            this.UI_Display_Tbx.Location = new System.Drawing.Point(12, 48);
            this.UI_Display_Tbx.Multiline = true;
            this.UI_Display_Tbx.Name = "UI_Display_Tbx";
            this.UI_Display_Tbx.ReadOnly = true;
            this.UI_Display_Tbx.Size = new System.Drawing.Size(296, 228);
            this.UI_Display_Tbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generated Values";
            // 
            // UI_NumValues_Tbx
            // 
            this.UI_NumValues_Tbx.Location = new System.Drawing.Point(540, 69);
            this.UI_NumValues_Tbx.Name = "UI_NumValues_Tbx";
            this.UI_NumValues_Tbx.Size = new System.Drawing.Size(208, 20);
            this.UI_NumValues_Tbx.TabIndex = 2;
            // 
            // UI_LowerLimit_Tbx
            // 
            this.UI_LowerLimit_Tbx.Location = new System.Drawing.Point(540, 123);
            this.UI_LowerLimit_Tbx.Name = "UI_LowerLimit_Tbx";
            this.UI_LowerLimit_Tbx.Size = new System.Drawing.Size(208, 20);
            this.UI_LowerLimit_Tbx.TabIndex = 3;
            // 
            // UI_UpperLimit_Tbx
            // 
            this.UI_UpperLimit_Tbx.Location = new System.Drawing.Point(540, 177);
            this.UI_UpperLimit_Tbx.Name = "UI_UpperLimit_Tbx";
            this.UI_UpperLimit_Tbx.Size = new System.Drawing.Size(208, 20);
            this.UI_UpperLimit_Tbx.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of Values: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(441, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lower Limit: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(439, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Upper Limit: ";
            // 
            // UI_GenerateValues_Btn
            // 
            this.UI_GenerateValues_Btn.Location = new System.Drawing.Point(540, 228);
            this.UI_GenerateValues_Btn.Name = "UI_GenerateValues_Btn";
            this.UI_GenerateValues_Btn.Size = new System.Drawing.Size(193, 32);
            this.UI_GenerateValues_Btn.TabIndex = 8;
            this.UI_GenerateValues_Btn.Text = "Generate Values";
            this.UI_GenerateValues_Btn.UseVisualStyleBackColor = true;
            this.UI_GenerateValues_Btn.Click += new System.EventHandler(this.UI_GenerateValues_Btn_Click);
            // 
            // UI_CalculateScore_Btn
            // 
            this.UI_CalculateScore_Btn.Location = new System.Drawing.Point(540, 284);
            this.UI_CalculateScore_Btn.Name = "UI_CalculateScore_Btn";
            this.UI_CalculateScore_Btn.Size = new System.Drawing.Size(193, 32);
            this.UI_CalculateScore_Btn.TabIndex = 9;
            this.UI_CalculateScore_Btn.Text = "Calculate Score";
            this.UI_CalculateScore_Btn.UseVisualStyleBackColor = true;
            this.UI_CalculateScore_Btn.Click += new System.EventHandler(this.UI_CalculateScore_Btn_Click);
            // 
            // UI_LoadData_Btn
            // 
            this.UI_LoadData_Btn.Location = new System.Drawing.Point(115, 350);
            this.UI_LoadData_Btn.Name = "UI_LoadData_Btn";
            this.UI_LoadData_Btn.Size = new System.Drawing.Size(193, 32);
            this.UI_LoadData_Btn.TabIndex = 10;
            this.UI_LoadData_Btn.Text = "Load Provided Data";
            this.UI_LoadData_Btn.UseVisualStyleBackColor = true;
            this.UI_LoadData_Btn.Click += new System.EventHandler(this.UI_LoadData_Btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(537, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Score: ";
            // 
            // UI_DataSet1_Radio
            // 
            this.UI_DataSet1_Radio.AutoSize = true;
            this.UI_DataSet1_Radio.Checked = true;
            this.UI_DataSet1_Radio.Location = new System.Drawing.Point(12, 317);
            this.UI_DataSet1_Radio.Name = "UI_DataSet1_Radio";
            this.UI_DataSet1_Radio.Size = new System.Drawing.Size(76, 17);
            this.UI_DataSet1_Radio.TabIndex = 13;
            this.UI_DataSet1_Radio.TabStop = true;
            this.UI_DataSet1_Radio.Text = "Data Set 1";
            this.UI_DataSet1_Radio.UseVisualStyleBackColor = true;
            // 
            // UI_DataSet2_Radio
            // 
            this.UI_DataSet2_Radio.AutoSize = true;
            this.UI_DataSet2_Radio.Location = new System.Drawing.Point(12, 358);
            this.UI_DataSet2_Radio.Name = "UI_DataSet2_Radio";
            this.UI_DataSet2_Radio.Size = new System.Drawing.Size(76, 17);
            this.UI_DataSet2_Radio.TabIndex = 14;
            this.UI_DataSet2_Radio.Text = "Data Set 2";
            this.UI_DataSet2_Radio.UseVisualStyleBackColor = true;
            // 
            // UI_DataSet3_Radio
            // 
            this.UI_DataSet3_Radio.AutoSize = true;
            this.UI_DataSet3_Radio.Location = new System.Drawing.Point(12, 399);
            this.UI_DataSet3_Radio.Name = "UI_DataSet3_Radio";
            this.UI_DataSet3_Radio.Size = new System.Drawing.Size(76, 17);
            this.UI_DataSet3_Radio.TabIndex = 15;
            this.UI_DataSet3_Radio.Text = "Data Set 3";
            this.UI_DataSet3_Radio.UseVisualStyleBackColor = true;
            // 
            // UI_Score_Tbx
            // 
            this.UI_Score_Tbx.Location = new System.Drawing.Point(598, 371);
            this.UI_Score_Tbx.Name = "UI_Score_Tbx";
            this.UI_Score_Tbx.ReadOnly = true;
            this.UI_Score_Tbx.Size = new System.Drawing.Size(135, 20);
            this.UI_Score_Tbx.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Score_Tbx);
            this.Controls.Add(this.UI_DataSet3_Radio);
            this.Controls.Add(this.UI_DataSet2_Radio);
            this.Controls.Add(this.UI_DataSet1_Radio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UI_LoadData_Btn);
            this.Controls.Add(this.UI_CalculateScore_Btn);
            this.Controls.Add(this.UI_GenerateValues_Btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UI_UpperLimit_Tbx);
            this.Controls.Add(this.UI_LowerLimit_Tbx);
            this.Controls.Add(this.UI_NumValues_Tbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_Display_Tbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_Display_Tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UI_NumValues_Tbx;
        private System.Windows.Forms.TextBox UI_LowerLimit_Tbx;
        private System.Windows.Forms.TextBox UI_UpperLimit_Tbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UI_GenerateValues_Btn;
        private System.Windows.Forms.Button UI_CalculateScore_Btn;
        private System.Windows.Forms.Button UI_LoadData_Btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton UI_DataSet1_Radio;
        private System.Windows.Forms.RadioButton UI_DataSet2_Radio;
        private System.Windows.Forms.RadioButton UI_DataSet3_Radio;
        private System.Windows.Forms.TextBox UI_Score_Tbx;
    }
}

