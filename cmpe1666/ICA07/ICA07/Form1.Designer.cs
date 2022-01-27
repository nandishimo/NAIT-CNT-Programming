
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
            this.bubbleButton = new System.Windows.Forms.RadioButton();
            this.selectionButton = new System.Windows.Forms.RadioButton();
            this.insertionButton = new System.Windows.Forms.RadioButton();
            this.quickButton = new System.Windows.Forms.RadioButton();
            this.numValLabel = new System.Windows.Forms.Label();
            this.minValLabel = new System.Windows.Forms.Label();
            this.maxValLabel = new System.Windows.Forms.Label();
            this.genBoxLabel = new System.Windows.Forms.Label();
            this.sortBoxLabel = new System.Windows.Forms.Label();
            this.methodGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // generatedBox
            // 
            this.generatedBox.Location = new System.Drawing.Point(41, 76);
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
            this.sortedBox.Location = new System.Drawing.Point(496, 76);
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
            this.numValBox.Location = new System.Drawing.Point(408, 76);
            this.numValBox.Name = "numValBox";
            this.numValBox.Size = new System.Drawing.Size(82, 20);
            this.numValBox.TabIndex = 0;
            // 
            // minValBox
            // 
            this.minValBox.Location = new System.Drawing.Point(408, 102);
            this.minValBox.Name = "minValBox";
            this.minValBox.Size = new System.Drawing.Size(82, 20);
            this.minValBox.TabIndex = 1;
            // 
            // maxValBox
            // 
            this.maxValBox.Location = new System.Drawing.Point(408, 128);
            this.maxValBox.Name = "maxValBox";
            this.maxValBox.Size = new System.Drawing.Size(82, 20);
            this.maxValBox.TabIndex = 2;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(348, 154);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(107, 39);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Generate Values";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(348, 362);
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
            this.methodGroup.Controls.Add(this.bubbleButton);
            this.methodGroup.Location = new System.Drawing.Point(331, 199);
            this.methodGroup.Name = "methodGroup";
            this.methodGroup.Size = new System.Drawing.Size(144, 152);
            this.methodGroup.TabIndex = 7;
            this.methodGroup.TabStop = false;
            this.methodGroup.Text = "Sorting Method";
            // 
            // bubbleButton
            // 
            this.bubbleButton.AutoSize = true;
            this.bubbleButton.Checked = true;
            this.bubbleButton.Location = new System.Drawing.Point(6, 19);
            this.bubbleButton.Name = "bubbleButton";
            this.bubbleButton.Size = new System.Drawing.Size(80, 17);
            this.bubbleButton.TabIndex = 4;
            this.bubbleButton.TabStop = true;
            this.bubbleButton.Text = "Bubble Sort";
            this.bubbleButton.UseVisualStyleBackColor = true;
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
            this.numValLabel.Location = new System.Drawing.Point(308, 79);
            this.numValLabel.Name = "numValLabel";
            this.numValLabel.Size = new System.Drawing.Size(94, 13);
            this.numValLabel.TabIndex = 8;
            this.numValLabel.Text = "Number of Values:";
            // 
            // minValLabel
            // 
            this.minValLabel.AutoSize = true;
            this.minValLabel.Location = new System.Drawing.Point(313, 105);
            this.minValLabel.Name = "minValLabel";
            this.minValLabel.Size = new System.Drawing.Size(81, 13);
            this.minValLabel.TabIndex = 9;
            this.minValLabel.Text = "Minimum Value:";
            // 
            // maxValLabel
            // 
            this.maxValLabel.AutoSize = true;
            this.maxValLabel.Location = new System.Drawing.Point(313, 131);
            this.maxValLabel.Name = "maxValLabel";
            this.maxValLabel.Size = new System.Drawing.Size(84, 13);
            this.maxValLabel.TabIndex = 10;
            this.maxValLabel.Text = "Maximum Value:";
            // 
            // genBoxLabel
            // 
            this.genBoxLabel.AutoSize = true;
            this.genBoxLabel.Location = new System.Drawing.Point(155, 60);
            this.genBoxLabel.Name = "genBoxLabel";
            this.genBoxLabel.Size = new System.Drawing.Size(92, 13);
            this.genBoxLabel.TabIndex = 11;
            this.genBoxLabel.Text = "Generated Values";
            // 
            // sortBoxLabel
            // 
            this.sortBoxLabel.AutoSize = true;
            this.sortBoxLabel.Location = new System.Drawing.Point(602, 60);
            this.sortBoxLabel.Name = "sortBoxLabel";
            this.sortBoxLabel.Size = new System.Drawing.Size(73, 13);
            this.sortBoxLabel.TabIndex = 12;
            this.sortBoxLabel.Text = "Sorted Values";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.RadioButton bubbleButton;
        private System.Windows.Forms.Label numValLabel;
        private System.Windows.Forms.Label minValLabel;
        private System.Windows.Forms.Label maxValLabel;
        private System.Windows.Forms.Label genBoxLabel;
        private System.Windows.Forms.Label sortBoxLabel;
    }
}

