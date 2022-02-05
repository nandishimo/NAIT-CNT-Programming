
namespace ICA08
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
            this.loadButton = new System.Windows.Forms.Button();
            this.clearSortedButton = new System.Windows.Forms.Button();
            this.quickSortButton = new System.Windows.Forms.Button();
            this.nSquaredSortButton = new System.Windows.Forms.Button();
            this.providedListRadio = new System.Windows.Forms.RadioButton();
            this.fileDataRadio = new System.Windows.Forms.RadioButton();
            this.clearUnsortedButton = new System.Windows.Forms.Button();
            this.displayUnsortedButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.elapsedTicksBox = new System.Windows.Forms.TextBox();
            this.unsortedBox = new System.Windows.Forms.ListBox();
            this.sortedBox = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(340, 360);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(123, 43);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load Files";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // clearSortedButton
            // 
            this.clearSortedButton.Location = new System.Drawing.Point(340, 311);
            this.clearSortedButton.Name = "clearSortedButton";
            this.clearSortedButton.Size = new System.Drawing.Size(123, 43);
            this.clearSortedButton.TabIndex = 3;
            this.clearSortedButton.Text = "Clear Sorted Listbox";
            this.clearSortedButton.UseVisualStyleBackColor = true;
            this.clearSortedButton.Click += new System.EventHandler(this.clearSortedButton_Click);
            // 
            // quickSortButton
            // 
            this.quickSortButton.Location = new System.Drawing.Point(340, 262);
            this.quickSortButton.Name = "quickSortButton";
            this.quickSortButton.Size = new System.Drawing.Size(123, 43);
            this.quickSortButton.TabIndex = 4;
            this.quickSortButton.Text = "Quick Sort";
            this.quickSortButton.UseVisualStyleBackColor = true;
            this.quickSortButton.Click += new System.EventHandler(this.quickSortButton_Click);
            // 
            // nSquaredSortButton
            // 
            this.nSquaredSortButton.Location = new System.Drawing.Point(340, 213);
            this.nSquaredSortButton.Name = "nSquaredSortButton";
            this.nSquaredSortButton.Size = new System.Drawing.Size(123, 43);
            this.nSquaredSortButton.TabIndex = 5;
            this.nSquaredSortButton.Text = "N^2 Sorting";
            this.nSquaredSortButton.UseVisualStyleBackColor = true;
            this.nSquaredSortButton.Click += new System.EventHandler(this.nSquaredSortButton_Click);
            // 
            // providedListRadio
            // 
            this.providedListRadio.AutoSize = true;
            this.providedListRadio.Checked = true;
            this.providedListRadio.Location = new System.Drawing.Point(356, 157);
            this.providedListRadio.Name = "providedListRadio";
            this.providedListRadio.Size = new System.Drawing.Size(86, 17);
            this.providedListRadio.TabIndex = 6;
            this.providedListRadio.TabStop = true;
            this.providedListRadio.Text = "Provided List";
            this.providedListRadio.UseVisualStyleBackColor = true;
            // 
            // fileDataRadio
            // 
            this.fileDataRadio.AutoSize = true;
            this.fileDataRadio.Location = new System.Drawing.Point(356, 180);
            this.fileDataRadio.Name = "fileDataRadio";
            this.fileDataRadio.Size = new System.Drawing.Size(67, 17);
            this.fileDataRadio.TabIndex = 7;
            this.fileDataRadio.TabStop = true;
            this.fileDataRadio.Text = "File Data";
            this.fileDataRadio.UseVisualStyleBackColor = true;
            // 
            // clearUnsortedButton
            // 
            this.clearUnsortedButton.Location = new System.Drawing.Point(340, 97);
            this.clearUnsortedButton.Name = "clearUnsortedButton";
            this.clearUnsortedButton.Size = new System.Drawing.Size(123, 43);
            this.clearUnsortedButton.TabIndex = 8;
            this.clearUnsortedButton.Text = "Clear Unsorted Listbox";
            this.clearUnsortedButton.UseVisualStyleBackColor = true;
            this.clearUnsortedButton.Click += new System.EventHandler(this.clearUnsortedButton_Click);
            // 
            // displayUnsortedButton
            // 
            this.displayUnsortedButton.Location = new System.Drawing.Point(340, 48);
            this.displayUnsortedButton.Name = "displayUnsortedButton";
            this.displayUnsortedButton.Size = new System.Drawing.Size(123, 43);
            this.displayUnsortedButton.TabIndex = 9;
            this.displayUnsortedButton.Text = "Display Unsorted List";
            this.displayUnsortedButton.UseVisualStyleBackColor = true;
            this.displayUnsortedButton.Click += new System.EventHandler(this.displayUnsortedButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Unsorted Data";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(603, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sorted Data";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(454, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Time Taken (Elaped Ticks):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // elapsedTicksBox
            // 
            this.elapsedTicksBox.Location = new System.Drawing.Point(668, 423);
            this.elapsedTicksBox.Name = "elapsedTicksBox";
            this.elapsedTicksBox.ReadOnly = true;
            this.elapsedTicksBox.Size = new System.Drawing.Size(120, 20);
            this.elapsedTicksBox.TabIndex = 13;
            // 
            // unsortedBox
            // 
            this.unsortedBox.FormattingEnabled = true;
            this.unsortedBox.Location = new System.Drawing.Point(12, 48);
            this.unsortedBox.Name = "unsortedBox";
            this.unsortedBox.Size = new System.Drawing.Size(275, 355);
            this.unsortedBox.TabIndex = 14;
            // 
            // sortedBox
            // 
            this.sortedBox.FormattingEnabled = true;
            this.sortedBox.Location = new System.Drawing.Point(513, 48);
            this.sortedBox.Name = "sortedBox";
            this.sortedBox.Size = new System.Drawing.Size(275, 355);
            this.sortedBox.TabIndex = 15;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Title = "Select Employee IDs File";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Title = "Select Employee Salaries File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sortedBox);
            this.Controls.Add(this.unsortedBox);
            this.Controls.Add(this.elapsedTicksBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayUnsortedButton);
            this.Controls.Add(this.clearUnsortedButton);
            this.Controls.Add(this.fileDataRadio);
            this.Controls.Add(this.providedListRadio);
            this.Controls.Add(this.nSquaredSortButton);
            this.Controls.Add(this.quickSortButton);
            this.Controls.Add(this.clearSortedButton);
            this.Controls.Add(this.loadButton);
            this.Name = "Form1";
            this.Text = "ICA08 - Sorting Structs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button clearSortedButton;
        private System.Windows.Forms.Button quickSortButton;
        private System.Windows.Forms.Button nSquaredSortButton;
        private System.Windows.Forms.RadioButton providedListRadio;
        private System.Windows.Forms.RadioButton fileDataRadio;
        private System.Windows.Forms.Button clearUnsortedButton;
        private System.Windows.Forms.Button displayUnsortedButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox elapsedTicksBox;
        private System.Windows.Forms.ListBox unsortedBox;
        private System.Windows.Forms.ListBox sortedBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

