
namespace ICA15
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
            this.UI_LB_RawData = new System.Windows.Forms.ListBox();
            this.lbl_RawDataList = new System.Windows.Forms.Label();
            this.lbl_DataSortedOn = new System.Windows.Forms.Label();
            this.lbl_SenWithTemp = new System.Windows.Forms.Label();
            this.UI_LB_SortedData = new System.Windows.Forms.ListBox();
            this.UI_LB_SensorWTemp = new System.Windows.Forms.ListBox();
            this.UI_BTN_GenerateS = new System.Windows.Forms.Button();
            this.UI_TB_NumSensors = new System.Windows.Forms.TextBox();
            this.UI_BTN_Redisplay = new System.Windows.Forms.Button();
            this.UI_BTN_DisplaySorted = new System.Windows.Forms.Button();
            this.UI_BTN_DispSelected = new System.Windows.Forms.Button();
            this.UI_GB_SortCriteria = new System.Windows.Forms.GroupBox();
            this.UI_RB_Temperature = new System.Windows.Forms.RadioButton();
            this.UI_RB_SensorID = new System.Windows.Forms.RadioButton();
            this.UI_GB_SortOrder = new System.Windows.Forms.GroupBox();
            this.UI_RB_Desc = new System.Windows.Forms.RadioButton();
            this.UI_RB_Ascending = new System.Windows.Forms.RadioButton();
            this.UI_TB_TempValue = new System.Windows.Forms.TextBox();
            this.UI_GB_SelectCriteria = new System.Windows.Forms.GroupBox();
            this.UI_RB_LessThan = new System.Windows.Forms.RadioButton();
            this.UI_RB_Greater = new System.Windows.Forms.RadioButton();
            this.lbl_numSensors = new System.Windows.Forms.Label();
            this.UI_TB_ = new System.Windows.Forms.Label();
            this.UI_GB_SortCriteria.SuspendLayout();
            this.UI_GB_SortOrder.SuspendLayout();
            this.UI_GB_SelectCriteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_LB_RawData
            // 
            this.UI_LB_RawData.FormattingEnabled = true;
            this.UI_LB_RawData.Location = new System.Drawing.Point(12, 25);
            this.UI_LB_RawData.Name = "UI_LB_RawData";
            this.UI_LB_RawData.Size = new System.Drawing.Size(245, 277);
            this.UI_LB_RawData.TabIndex = 0;
            // 
            // lbl_RawDataList
            // 
            this.lbl_RawDataList.AutoSize = true;
            this.lbl_RawDataList.Location = new System.Drawing.Point(12, 9);
            this.lbl_RawDataList.Name = "lbl_RawDataList";
            this.lbl_RawDataList.Size = new System.Drawing.Size(74, 13);
            this.lbl_RawDataList.TabIndex = 3;
            this.lbl_RawDataList.Text = "Raw Data List";
            // 
            // lbl_DataSortedOn
            // 
            this.lbl_DataSortedOn.AutoSize = true;
            this.lbl_DataSortedOn.Location = new System.Drawing.Point(270, 9);
            this.lbl_DataSortedOn.Name = "lbl_DataSortedOn";
            this.lbl_DataSortedOn.Size = new System.Drawing.Size(81, 13);
            this.lbl_DataSortedOn.TabIndex = 4;
            this.lbl_DataSortedOn.Text = "Data Sorted On";
            // 
            // lbl_SenWithTemp
            // 
            this.lbl_SenWithTemp.AutoSize = true;
            this.lbl_SenWithTemp.Location = new System.Drawing.Point(540, 9);
            this.lbl_SenWithTemp.Name = "lbl_SenWithTemp";
            this.lbl_SenWithTemp.Size = new System.Drawing.Size(138, 13);
            this.lbl_SenWithTemp.TabIndex = 5;
            this.lbl_SenWithTemp.Text = "Sensors With Temperatures";
            // 
            // UI_LB_SortedData
            // 
            this.UI_LB_SortedData.FormattingEnabled = true;
            this.UI_LB_SortedData.Location = new System.Drawing.Point(273, 25);
            this.UI_LB_SortedData.Name = "UI_LB_SortedData";
            this.UI_LB_SortedData.Size = new System.Drawing.Size(245, 277);
            this.UI_LB_SortedData.TabIndex = 6;
            // 
            // UI_LB_SensorWTemp
            // 
            this.UI_LB_SensorWTemp.FormattingEnabled = true;
            this.UI_LB_SensorWTemp.Location = new System.Drawing.Point(543, 25);
            this.UI_LB_SensorWTemp.Name = "UI_LB_SensorWTemp";
            this.UI_LB_SensorWTemp.Size = new System.Drawing.Size(245, 277);
            this.UI_LB_SensorWTemp.TabIndex = 7;
            // 
            // UI_BTN_GenerateS
            // 
            this.UI_BTN_GenerateS.Location = new System.Drawing.Point(12, 308);
            this.UI_BTN_GenerateS.Name = "UI_BTN_GenerateS";
            this.UI_BTN_GenerateS.Size = new System.Drawing.Size(245, 33);
            this.UI_BTN_GenerateS.TabIndex = 8;
            this.UI_BTN_GenerateS.Text = "Generate Sensors";
            this.UI_BTN_GenerateS.UseVisualStyleBackColor = true;
            this.UI_BTN_GenerateS.Click += new System.EventHandler(this.UI_BTN_GenerateS_Click);
            // 
            // UI_TB_NumSensors
            // 
            this.UI_TB_NumSensors.Location = new System.Drawing.Point(15, 373);
            this.UI_TB_NumSensors.Name = "UI_TB_NumSensors";
            this.UI_TB_NumSensors.Size = new System.Drawing.Size(242, 20);
            this.UI_TB_NumSensors.TabIndex = 9;
            // 
            // UI_BTN_Redisplay
            // 
            this.UI_BTN_Redisplay.Location = new System.Drawing.Point(12, 405);
            this.UI_BTN_Redisplay.Name = "UI_BTN_Redisplay";
            this.UI_BTN_Redisplay.Size = new System.Drawing.Size(245, 33);
            this.UI_BTN_Redisplay.TabIndex = 10;
            this.UI_BTN_Redisplay.Text = "Redisplay";
            this.UI_BTN_Redisplay.UseVisualStyleBackColor = true;
            this.UI_BTN_Redisplay.Click += new System.EventHandler(this.UI_BTN_Redisplay_Click);
            // 
            // UI_BTN_DisplaySorted
            // 
            this.UI_BTN_DisplaySorted.Location = new System.Drawing.Point(273, 405);
            this.UI_BTN_DisplaySorted.Name = "UI_BTN_DisplaySorted";
            this.UI_BTN_DisplaySorted.Size = new System.Drawing.Size(245, 33);
            this.UI_BTN_DisplaySorted.TabIndex = 11;
            this.UI_BTN_DisplaySorted.Text = "Display Sorted";
            this.UI_BTN_DisplaySorted.UseVisualStyleBackColor = true;
            this.UI_BTN_DisplaySorted.Click += new System.EventHandler(this.UI_BTN_DisplaySorted_Click);
            // 
            // UI_BTN_DispSelected
            // 
            this.UI_BTN_DispSelected.Location = new System.Drawing.Point(543, 405);
            this.UI_BTN_DispSelected.Name = "UI_BTN_DispSelected";
            this.UI_BTN_DispSelected.Size = new System.Drawing.Size(245, 33);
            this.UI_BTN_DispSelected.TabIndex = 12;
            this.UI_BTN_DispSelected.Text = "Display Selected";
            this.UI_BTN_DispSelected.UseVisualStyleBackColor = true;
            this.UI_BTN_DispSelected.Click += new System.EventHandler(this.UI_BTN_DispSelected_Click);
            // 
            // UI_GB_SortCriteria
            // 
            this.UI_GB_SortCriteria.Controls.Add(this.UI_RB_Temperature);
            this.UI_GB_SortCriteria.Controls.Add(this.UI_RB_SensorID);
            this.UI_GB_SortCriteria.Location = new System.Drawing.Point(273, 308);
            this.UI_GB_SortCriteria.Name = "UI_GB_SortCriteria";
            this.UI_GB_SortCriteria.Size = new System.Drawing.Size(245, 43);
            this.UI_GB_SortCriteria.TabIndex = 13;
            this.UI_GB_SortCriteria.TabStop = false;
            this.UI_GB_SortCriteria.Text = "Sort Criteria";
            // 
            // UI_RB_Temperature
            // 
            this.UI_RB_Temperature.AutoSize = true;
            this.UI_RB_Temperature.Location = new System.Drawing.Point(154, 16);
            this.UI_RB_Temperature.Name = "UI_RB_Temperature";
            this.UI_RB_Temperature.Size = new System.Drawing.Size(85, 17);
            this.UI_RB_Temperature.TabIndex = 1;
            this.UI_RB_Temperature.Text = "Temperature";
            this.UI_RB_Temperature.UseVisualStyleBackColor = true;
            // 
            // UI_RB_SensorID
            // 
            this.UI_RB_SensorID.AutoSize = true;
            this.UI_RB_SensorID.Checked = true;
            this.UI_RB_SensorID.Location = new System.Drawing.Point(6, 16);
            this.UI_RB_SensorID.Name = "UI_RB_SensorID";
            this.UI_RB_SensorID.Size = new System.Drawing.Size(72, 17);
            this.UI_RB_SensorID.TabIndex = 0;
            this.UI_RB_SensorID.TabStop = true;
            this.UI_RB_SensorID.Text = "Sensor ID";
            this.UI_RB_SensorID.UseVisualStyleBackColor = true;
            // 
            // UI_GB_SortOrder
            // 
            this.UI_GB_SortOrder.Controls.Add(this.UI_RB_Desc);
            this.UI_GB_SortOrder.Controls.Add(this.UI_RB_Ascending);
            this.UI_GB_SortOrder.Location = new System.Drawing.Point(273, 357);
            this.UI_GB_SortOrder.Name = "UI_GB_SortOrder";
            this.UI_GB_SortOrder.Size = new System.Drawing.Size(245, 43);
            this.UI_GB_SortOrder.TabIndex = 14;
            this.UI_GB_SortOrder.TabStop = false;
            this.UI_GB_SortOrder.Text = "Sort Order";
            // 
            // UI_RB_Desc
            // 
            this.UI_RB_Desc.AutoSize = true;
            this.UI_RB_Desc.Location = new System.Drawing.Point(154, 16);
            this.UI_RB_Desc.Name = "UI_RB_Desc";
            this.UI_RB_Desc.Size = new System.Drawing.Size(82, 17);
            this.UI_RB_Desc.TabIndex = 1;
            this.UI_RB_Desc.Text = "Descending";
            this.UI_RB_Desc.UseVisualStyleBackColor = true;
            // 
            // UI_RB_Ascending
            // 
            this.UI_RB_Ascending.AutoSize = true;
            this.UI_RB_Ascending.Checked = true;
            this.UI_RB_Ascending.Location = new System.Drawing.Point(6, 16);
            this.UI_RB_Ascending.Name = "UI_RB_Ascending";
            this.UI_RB_Ascending.Size = new System.Drawing.Size(75, 17);
            this.UI_RB_Ascending.TabIndex = 0;
            this.UI_RB_Ascending.TabStop = true;
            this.UI_RB_Ascending.Text = "Ascending";
            this.UI_RB_Ascending.UseVisualStyleBackColor = true;
            // 
            // UI_TB_TempValue
            // 
            this.UI_TB_TempValue.Location = new System.Drawing.Point(543, 324);
            this.UI_TB_TempValue.Name = "UI_TB_TempValue";
            this.UI_TB_TempValue.Size = new System.Drawing.Size(245, 20);
            this.UI_TB_TempValue.TabIndex = 15;
            // 
            // UI_GB_SelectCriteria
            // 
            this.UI_GB_SelectCriteria.Controls.Add(this.UI_RB_LessThan);
            this.UI_GB_SelectCriteria.Controls.Add(this.UI_RB_Greater);
            this.UI_GB_SelectCriteria.Location = new System.Drawing.Point(543, 356);
            this.UI_GB_SelectCriteria.Name = "UI_GB_SelectCriteria";
            this.UI_GB_SelectCriteria.Size = new System.Drawing.Size(273, 43);
            this.UI_GB_SelectCriteria.TabIndex = 15;
            this.UI_GB_SelectCriteria.TabStop = false;
            this.UI_GB_SelectCriteria.Text = "Selection Criteria";
            // 
            // UI_RB_LessThan
            // 
            this.UI_RB_LessThan.AutoSize = true;
            this.UI_RB_LessThan.Location = new System.Drawing.Point(154, 16);
            this.UI_RB_LessThan.Name = "UI_RB_LessThan";
            this.UI_RB_LessThan.Size = new System.Drawing.Size(117, 17);
            this.UI_RB_LessThan.TabIndex = 1;
            this.UI_RB_LessThan.Text = "Less Than or Equal";
            this.UI_RB_LessThan.UseVisualStyleBackColor = true;
            // 
            // UI_RB_Greater
            // 
            this.UI_RB_Greater.AutoSize = true;
            this.UI_RB_Greater.Checked = true;
            this.UI_RB_Greater.Location = new System.Drawing.Point(6, 16);
            this.UI_RB_Greater.Name = "UI_RB_Greater";
            this.UI_RB_Greater.Size = new System.Drawing.Size(130, 17);
            this.UI_RB_Greater.TabIndex = 0;
            this.UI_RB_Greater.TabStop = true;
            this.UI_RB_Greater.Text = "Greater Than or Equal";
            this.UI_RB_Greater.UseVisualStyleBackColor = true;
            // 
            // lbl_numSensors
            // 
            this.lbl_numSensors.AutoSize = true;
            this.lbl_numSensors.Location = new System.Drawing.Point(12, 356);
            this.lbl_numSensors.Name = "lbl_numSensors";
            this.lbl_numSensors.Size = new System.Drawing.Size(97, 13);
            this.lbl_numSensors.TabIndex = 16;
            this.lbl_numSensors.Text = "Number of Sensors";
            // 
            // UI_TB_
            // 
            this.UI_TB_.AutoSize = true;
            this.UI_TB_.Location = new System.Drawing.Point(546, 308);
            this.UI_TB_.Name = "UI_TB_";
            this.UI_TB_.Size = new System.Drawing.Size(97, 13);
            this.UI_TB_.TabIndex = 17;
            this.UI_TB_.Text = "Temperature Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.UI_TB_);
            this.Controls.Add(this.lbl_numSensors);
            this.Controls.Add(this.UI_GB_SelectCriteria);
            this.Controls.Add(this.UI_TB_TempValue);
            this.Controls.Add(this.UI_GB_SortOrder);
            this.Controls.Add(this.UI_GB_SortCriteria);
            this.Controls.Add(this.UI_BTN_DispSelected);
            this.Controls.Add(this.UI_BTN_DisplaySorted);
            this.Controls.Add(this.UI_BTN_Redisplay);
            this.Controls.Add(this.UI_TB_NumSensors);
            this.Controls.Add(this.UI_BTN_GenerateS);
            this.Controls.Add(this.UI_LB_SensorWTemp);
            this.Controls.Add(this.UI_LB_SortedData);
            this.Controls.Add(this.lbl_SenWithTemp);
            this.Controls.Add(this.lbl_DataSortedOn);
            this.Controls.Add(this.lbl_RawDataList);
            this.Controls.Add(this.UI_LB_RawData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UI_GB_SortCriteria.ResumeLayout(false);
            this.UI_GB_SortCriteria.PerformLayout();
            this.UI_GB_SortOrder.ResumeLayout(false);
            this.UI_GB_SortOrder.PerformLayout();
            this.UI_GB_SelectCriteria.ResumeLayout(false);
            this.UI_GB_SelectCriteria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UI_LB_RawData;
        private System.Windows.Forms.Label lbl_RawDataList;
        private System.Windows.Forms.Label lbl_DataSortedOn;
        private System.Windows.Forms.Label lbl_SenWithTemp;
        private System.Windows.Forms.ListBox UI_LB_SortedData;
        private System.Windows.Forms.ListBox UI_LB_SensorWTemp;
        private System.Windows.Forms.Button UI_BTN_GenerateS;
        private System.Windows.Forms.TextBox UI_TB_NumSensors;
        private System.Windows.Forms.Button UI_BTN_Redisplay;
        private System.Windows.Forms.Button UI_BTN_DisplaySorted;
        private System.Windows.Forms.Button UI_BTN_DispSelected;
        private System.Windows.Forms.GroupBox UI_GB_SortCriteria;
        private System.Windows.Forms.RadioButton UI_RB_Temperature;
        private System.Windows.Forms.RadioButton UI_RB_SensorID;
        private System.Windows.Forms.GroupBox UI_GB_SortOrder;
        private System.Windows.Forms.RadioButton UI_RB_Desc;
        private System.Windows.Forms.RadioButton UI_RB_Ascending;
        private System.Windows.Forms.TextBox UI_TB_TempValue;
        private System.Windows.Forms.GroupBox UI_GB_SelectCriteria;
        private System.Windows.Forms.RadioButton UI_RB_LessThan;
        private System.Windows.Forms.RadioButton UI_RB_Greater;
        private System.Windows.Forms.Label lbl_numSensors;
        private System.Windows.Forms.Label UI_TB_;
    }
}

