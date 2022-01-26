
namespace ICA06
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
            this.nameList = new System.Windows.Forms.ListBox();
            this.sortedNamesList = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nameEntryButton = new System.Windows.Forms.Button();
            this.nameSearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // nameList
            // 
            this.nameList.FormattingEnabled = true;
            this.nameList.Location = new System.Drawing.Point(10, 35);
            this.nameList.Name = "nameList";
            this.nameList.Size = new System.Drawing.Size(167, 225);
            this.nameList.TabIndex = 0;
            // 
            // sortedNamesList
            // 
            this.sortedNamesList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortedNamesList.FormattingEnabled = true;
            this.sortedNamesList.Location = new System.Drawing.Point(436, 35);
            this.sortedNamesList.Name = "sortedNamesList";
            this.sortedNamesList.Size = new System.Drawing.Size(167, 225);
            this.sortedNamesList.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 2;
            // 
            // nameEntryButton
            // 
            this.nameEntryButton.Location = new System.Drawing.Point(231, 125);
            this.nameEntryButton.Name = "nameEntryButton";
            this.nameEntryButton.Size = new System.Drawing.Size(163, 30);
            this.nameEntryButton.TabIndex = 3;
            this.nameEntryButton.Text = "Add Name";
            this.nameEntryButton.UseVisualStyleBackColor = true;
            this.nameEntryButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameSearchButton
            // 
            this.nameSearchButton.Location = new System.Drawing.Point(231, 196);
            this.nameSearchButton.Name = "nameSearchButton";
            this.nameSearchButton.Size = new System.Drawing.Size(163, 30);
            this.nameSearchButton.TabIndex = 4;
            this.nameSearchButton.Text = "Search";
            this.nameSearchButton.UseVisualStyleBackColor = true;
            this.nameSearchButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "List of Names (Order of Entry)";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "List of Names (Sorted)";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(187, 64);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 278);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameSearchButton);
            this.Controls.Add(this.nameEntryButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sortedNamesList);
            this.Controls.Add(this.nameList);
            this.MaximumSize = new System.Drawing.Size(633, 317);
            this.MinimumSize = new System.Drawing.Size(633, 317);
            this.Name = "Form1";
            this.Text = "ICA06";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox nameList;
        private System.Windows.Forms.ListBox sortedNamesList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button nameEntryButton;
        private System.Windows.Forms.Button nameSearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

