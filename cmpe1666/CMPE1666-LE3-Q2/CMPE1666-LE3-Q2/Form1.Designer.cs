
namespace CMPE1666_LE3_Q2
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
            this.UI_Track_MaxCount = new System.Windows.Forms.TrackBar();
            this.UI_BTN_Start = new System.Windows.Forms.Button();
            this.LBL_Min = new System.Windows.Forms.Label();
            this.LBL_Max = new System.Windows.Forms.Label();
            this.UI_BTN_Stop = new System.Windows.Forms.Button();
            this.UI_LBL_Count = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Track_MaxCount)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_Track_MaxCount
            // 
            this.UI_Track_MaxCount.Location = new System.Drawing.Point(12, 12);
            this.UI_Track_MaxCount.Minimum = 1;
            this.UI_Track_MaxCount.Name = "UI_Track_MaxCount";
            this.UI_Track_MaxCount.Size = new System.Drawing.Size(461, 45);
            this.UI_Track_MaxCount.TabIndex = 0;
            this.UI_Track_MaxCount.Value = 1;
            // 
            // UI_BTN_Start
            // 
            this.UI_BTN_Start.Location = new System.Drawing.Point(12, 63);
            this.UI_BTN_Start.Name = "UI_BTN_Start";
            this.UI_BTN_Start.Size = new System.Drawing.Size(75, 23);
            this.UI_BTN_Start.TabIndex = 1;
            this.UI_BTN_Start.Text = "Start";
            this.UI_BTN_Start.UseVisualStyleBackColor = true;
            this.UI_BTN_Start.Click += new System.EventHandler(this.UI_BTN_Start_Click);
            // 
            // LBL_Min
            // 
            this.LBL_Min.AutoSize = true;
            this.LBL_Min.Location = new System.Drawing.Point(21, 44);
            this.LBL_Min.Name = "LBL_Min";
            this.LBL_Min.Size = new System.Drawing.Size(13, 13);
            this.LBL_Min.TabIndex = 2;
            this.LBL_Min.Text = "1";
            // 
            // LBL_Max
            // 
            this.LBL_Max.AutoSize = true;
            this.LBL_Max.Location = new System.Drawing.Point(454, 44);
            this.LBL_Max.Name = "LBL_Max";
            this.LBL_Max.Size = new System.Drawing.Size(19, 13);
            this.LBL_Max.TabIndex = 3;
            this.LBL_Max.Text = "10";
            // 
            // UI_BTN_Stop
            // 
            this.UI_BTN_Stop.Location = new System.Drawing.Point(93, 63);
            this.UI_BTN_Stop.Name = "UI_BTN_Stop";
            this.UI_BTN_Stop.Size = new System.Drawing.Size(75, 23);
            this.UI_BTN_Stop.TabIndex = 4;
            this.UI_BTN_Stop.Text = "Stop";
            this.UI_BTN_Stop.UseVisualStyleBackColor = true;
            this.UI_BTN_Stop.Click += new System.EventHandler(this.UI_BTN_Stop_Click);
            // 
            // UI_LBL_Count
            // 
            this.UI_LBL_Count.AutoSize = true;
            this.UI_LBL_Count.Location = new System.Drawing.Point(207, 68);
            this.UI_LBL_Count.Name = "UI_LBL_Count";
            this.UI_LBL_Count.Size = new System.Drawing.Size(13, 13);
            this.UI_LBL_Count.TabIndex = 5;
            this.UI_LBL_Count.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 106);
            this.Controls.Add(this.UI_LBL_Count);
            this.Controls.Add(this.UI_BTN_Stop);
            this.Controls.Add(this.LBL_Max);
            this.Controls.Add(this.LBL_Min);
            this.Controls.Add(this.UI_BTN_Start);
            this.Controls.Add(this.UI_Track_MaxCount);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UI_Track_MaxCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar UI_Track_MaxCount;
        private System.Windows.Forms.Button UI_BTN_Start;
        private System.Windows.Forms.Label LBL_Min;
        private System.Windows.Forms.Label LBL_Max;
        private System.Windows.Forms.Button UI_BTN_Stop;
        private System.Windows.Forms.Label UI_LBL_Count;
    }
}

