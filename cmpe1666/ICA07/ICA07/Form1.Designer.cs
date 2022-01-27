
namespace ICA07
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
            this.generatedBox = new System.Windows.Forms.TextBox();
            this.sortedBox = new System.Windows.Forms.TextBox();
            this.numValBox = new System.Windows.Forms.TextBox();
            this.minValBox = new System.Windows.Forms.TextBox();
            this.maxValBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.methodGroup = new System.Windows.Forms.GroupBox();
            this.clearSortButton = new System.Windows.Forms.RadioButton();
            this.selectionButton = new System.Windows.Forms.RadioButton();
            this.insertionButton = new System.Windows.Forms.RadioButton();
            this.quickButton = new System.Windows.Forms.RadioButton();
            this.numValLabel = new System.Windows.Forms.Label();
            this.minValLabel = new System.Windows.Forms.Label();
            this.maxValLabel = new System.Windows.Forms.Label();
            this.genBoxLabel = new System.Windows.Forms.Label();
            this.sortBoxLabel = new System.Windows.Forms.Label();
            this.clearRawButton = new System.Windows.Forms.Button();
            this.reDisplayButton = new System.Windows.Forms.Button();
            this.sortClearButton = new System.Windows.Forms.Button();
            this.sortingTimeLabel = new System.Windows.Forms.Label();
            this.sortingTimeBox = new System.Windows.Forms.TextBox();
            this.methodGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // generatedBox
            // 
            this.generatedBox.Location = new System.Drawing.Point(43, 51);
            this.generatedBox.Multiline = true;
            this.generatedBox.Name = "generatedBox";
            this.generatedBox.ReadOnly = true;
            this.generatedBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.generatedBox.Size = new System.Drawing.Size(253, 325);
            this.generatedBox.TabIndex = 0;
            this.generatedBox.TabStop = false;
            // 
            // sortedBox
            // 
            this.sortedBox.Location = new System.Drawing.Point(498, 51);
            this.sortedBox.Multiline = true;
            this.sortedBox.Name = "sortedBox";
            this.sortedBox.ReadOnly = true;
            this.sortedBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sortedBox.Size = new System.Drawing.Size(253, 325);
            this.sortedBox.TabIndex = 0;
            this.sortedBox.TabStop = false;
            // 
            // numValBox
            // 
            this.numValBox.Location = new System.Drawing.Point(410, 51);
            this.numValBox.Name = "numValBox";
            this.numValBox.Size = new System.Drawing.Size(82, 20);
            this.numValBox.TabIndex = 0;
            // 
            // minValBox
            // 
            this.minValBox.Location = new System.Drawing.Point(410, 77);
            this.minValBox.Name = "minValBox";
            this.minValBox.Size = new System.Drawing.Size(82, 20);
            this.minValBox.TabIndex = 1;
            // 
            // maxValBox
            // 
            this.maxValBox.Location = new System.Drawing.Point(410, 103);
            this.maxValBox.Name = "maxValBox";
            this.maxValBox.Size = new System.Drawing.Size(82, 20);
            this.maxValBox.TabIndex = 2;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(350, 129);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(107, 39);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Generate Values";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(350, 337);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(107, 39);
            this.sortButton.TabIndex = 8;
            this.sortButton.Text = "Sort Values";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // methodGroup
            // 
            this.methodGroup.Controls.Add(this.quickButton);
            this.methodGroup.Controls.Add(this.insertionButton);
            this.methodGroup.Controls.Add(this.selectionButton);
            this.methodGroup.Controls.Add(this.clearSortButton);
            this.methodGroup.Location = new System.Drawing.Point(350, 189);
            this.methodGroup.Name = "methodGroup";
            this.methodGroup.Size = new System.Drawing.Size(111, 125);
            this.methodGroup.TabIndex = 7;
            this.methodGroup.TabStop = false;
            this.methodGroup.Text = "Sorting Method";
            // 
            // clearSortButton
            // 
            this.clearSortButton.AutoSize = true;
            this.clearSortButton.Checked = true;
            this.clearSortButton.Location = new System.Drawing.Point(6, 19);
            this.clearSortButton.Name = "clearSortButton";
            this.clearSortButton.Size = new System.Drawing.Size(80, 17);
            this.clearSortButton.TabIndex = 4;
            this.clearSortButton.TabStop = true;
            this.clearSortButton.Text = "Bubble Sort";
            this.clearSortButton.UseVisualStyleBackColor = true;
            // 
            // selectionButton
            // 
            this.selectionButton.AutoSize = true;
            this.selectionButton.Location = new System.Drawing.Point(6, 42);
            this.selectionButton.Name = "selectionButton";
            this.selectionButton.Size = new System.Drawing.Size(91, 17);
            this.selectionButton.TabIndex = 5;
            this.selectionButton.Text = "Selection Sort";
            this.selectionButton.UseVisualStyleBackColor = true;
            // 
            // insertionButton
            // 
            this.insertionButton.AutoSize = true;
            this.insertionButton.Location = new System.Drawing.Point(6, 65);
            this.insertionButton.Name = "insertionButton";
            this.insertionButton.Size = new System.Drawing.Size(87, 17);
            this.insertionButton.TabIndex = 6;
            this.insertionButton.Text = "Insertion Sort";
            this.insertionButton.UseVisualStyleBackColor = true;
            // 
            // quickButton
            // 
            this.quickButton.AutoSize = true;
            this.quickButton.Location = new System.Drawing.Point(6, 88);
            this.quickButton.Name = "quickButton";
            this.quickButton.Size = new System.Drawing.Size(75, 17);
            this.quickButton.TabIndex = 7;
            this.quickButton.Text = "Quick Sort";
            this.quickButton.UseVisualStyleBackColor = true;
            // 
            // numValLabel
            // 
            this.numValLabel.AutoSize = true;
            this.numValLabel.Location = new System.Drawing.Point(310, 54);
            this.numValLabel.Name = "numValLabel";
            this.numValLabel.Size = new System.Drawing.Size(94, 13);
            this.numValLabel.TabIndex = 8;
            this.numValLabel.Text = "Number of Values:";
            // 
            // minValLabel
            // 
            this.minValLabel.AutoSize = true;
            this.minValLabel.Location = new System.Drawing.Point(310, 80);
            this.minValLabel.Name = "minValLabel";
            this.minValLabel.Size = new System.Drawing.Size(81, 13);
            this.minValLabel.TabIndex = 9;
            this.minValLabel.Text = "Minimum Value:";
            // 
            // maxValLabel
            // 
            this.maxValLabel.AutoSize = true;
            this.maxValLabel.Location = new System.Drawing.Point(310, 106);
            this.maxValLabel.Name = "maxValLabel";
            this.maxValLabel.Size = new System.Drawing.Size(84, 13);
            this.maxValLabel.TabIndex = 10;
            this.maxValLabel.Text = "Maximum Value:";
            // 
            // genBoxLabel
            // 
            this.genBoxLabel.AutoSize = true;
            this.genBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genBoxLabel.Location = new System.Drawing.Point(117, 32);
            this.genBoxLabel.Name = "genBoxLabel";
            this.genBoxLabel.Size = new System.Drawing.Size(117, 16);
            this.genBoxLabel.TabIndex = 11;
            this.genBoxLabel.Text = "Generated Values";
            // 
            // sortBoxLabel
            // 
            this.sortBoxLabel.AutoSize = true;
            this.sortBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortBoxLabel.Location = new System.Drawing.Point(584, 32);
            this.sortBoxLabel.Name = "sortBoxLabel";
            this.sortBoxLabel.Size = new System.Drawing.Size(93, 16);
            this.sortBoxLabel.TabIndex = 12;
            this.sortBoxLabel.Text = "Sorted Values";
            // 
            // clearRawButton
            // 
            this.clearRawButton.Location = new System.Drawing.Point(43, 382);
            this.clearRawButton.Name = "clearRawButton";
            this.clearRawButton.Size = new System.Drawing.Size(107, 39);
            this.clearRawButton.TabIndex = 13;
            this.clearRawButton.Text = "Clear Raw";
            this.clearRawButton.UseVisualStyleBackColor = true;
            this.clearRawButton.Click += new System.EventHandler(this.clearRawButton_Click);
            // 
            // reDisplayButton
            // 
            this.reDisplayButton.Location = new System.Drawing.Point(160, 382);
            this.reDisplayButton.Name = "reDisplayButton";
            this.reDisplayButton.Size = new System.Drawing.Size(107, 39);
            this.reDisplayButton.TabIndex = 14;
            this.reDisplayButton.Text = "Redisplay";
            this.reDisplayButton.UseVisualStyleBackColor = true;
            this.reDisplayButton.Click += new System.EventHandler(this.reDisplayButton_Click);
            // 
            // sortClearButton
            // 
            this.sortClearButton.Location = new System.Drawing.Point(570, 382);
            this.sortClearButton.Name = "sortClearButton";
            this.sortClearButton.Size = new System.Drawing.Size(107, 39);
            this.sortClearButton.TabIndex = 15;
            this.sortClearButton.Text = "Clear Sorted";
            this.sortClearButton.UseVisualStyleBackColor = true;
            this.sortClearButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // sortingTimeLabel
            // 
            this.sortingTimeLabel.AutoSize = true;
            this.sortingTimeLabel.Location = new System.Drawing.Point(304, 395);
            this.sortingTimeLabel.Name = "sortingTimeLabel";
            this.sortingTimeLabel.Size = new System.Drawing.Size(100, 13);
            this.sortingTimeLabel.TabIndex = 17;
            this.sortingTimeLabel.Text = "Sorting Time (ticks):";
            // 
            // sortingTimeBox
            // 
            this.sortingTimeBox.Location = new System.Drawing.Point(410, 392);
            this.sortingTimeBox.Name = "sortingTimeBox";
            this.sortingTimeBox.ReadOnly = true;
            this.sortingTimeBox.Size = new System.Drawing.Size(82, 20);
            this.sortingTimeBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sortingTimeLabel);
            this.Controls.Add(this.sortingTimeBox);
            this.Controls.Add(this.sortClearButton);
            this.Controls.Add(this.reDisplayButton);
            this.Controls.Add(this.clearRawButton);
            this.Controls.Add(this.sortBoxLabel);
            this.Controls.Add(this.genBoxLabel);
            this.Controls.Add(this.maxValLabel);
            this.Controls.Add(this.minValLabel);
            this.Controls.Add(this.numValLabel);
            this.Controls.Add(this.methodGroup);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.maxValBox);
            this.Controls.Add(this.minValBox);
            this.Controls.Add(this.numValBox);
            this.Controls.Add(this.sortedBox);
            this.Controls.Add(this.generatedBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.methodGroup.ResumeLayout(false);
            this.methodGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox generatedBox;
        private System.Windows.Forms.TextBox sortedBox;
        private System.Windows.Forms.TextBox numValBox;
        private System.Windows.Forms.TextBox minValBox;
        private System.Windows.Forms.TextBox maxValBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.GroupBox methodGroup;
        private System.Windows.Forms.RadioButton quickButton;
        private System.Windows.Forms.RadioButton insertionButton;
        private System.Windows.Forms.RadioButton selectionButton;
        private System.Windows.Forms.RadioButton clearSortButton;
        private System.Windows.Forms.Label numValLabel;
        private System.Windows.Forms.Label minValLabel;
        private System.Windows.Forms.Label maxValLabel;
        private System.Windows.Forms.Label genBoxLabel;
        private System.Windows.Forms.Label sortBoxLabel;
        private System.Windows.Forms.Button clearRawButton;
        private System.Windows.Forms.Button reDisplayButton;
        private System.Windows.Forms.Button sortClearButton;
        private System.Windows.Forms.Label sortingTimeLabel;
        private System.Windows.Forms.TextBox sortingTimeBox;
    }
}

