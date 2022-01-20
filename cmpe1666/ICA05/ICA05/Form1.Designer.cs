
namespace ICA05
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
            this.unitsGroup = new System.Windows.Forms.GroupBox();
            this.kphButton = new System.Windows.Forms.RadioButton();
            this.mphButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.unitsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // unitsGroup
            // 
            this.unitsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitsGroup.Controls.Add(this.kphButton);
            this.unitsGroup.Controls.Add(this.mphButton);
            this.unitsGroup.Location = new System.Drawing.Point(12, 12);
            this.unitsGroup.Name = "unitsGroup";
            this.unitsGroup.Size = new System.Drawing.Size(209, 70);
            this.unitsGroup.TabIndex = 0;
            this.unitsGroup.TabStop = false;
            this.unitsGroup.Text = "Input Units";
            // 
            // kphButton
            // 
            this.kphButton.AutoSize = true;
            this.kphButton.Location = new System.Drawing.Point(6, 42);
            this.kphButton.Name = "kphButton";
            this.kphButton.Size = new System.Drawing.Size(145, 17);
            this.kphButton.TabIndex = 1;
            this.kphButton.TabStop = true;
            this.kphButton.Text = "Kilometres Per Hour (kph)";
            this.kphButton.UseVisualStyleBackColor = true;
            this.kphButton.CheckedChanged += new System.EventHandler(this.val_Changed);
            // 
            // mphButton
            // 
            this.mphButton.AutoSize = true;
            this.mphButton.Checked = true;
            this.mphButton.Location = new System.Drawing.Point(6, 19);
            this.mphButton.Name = "mphButton";
            this.mphButton.Size = new System.Drawing.Size(123, 17);
            this.mphButton.TabIndex = 0;
            this.mphButton.TabStop = true;
            this.mphButton.Text = "Miles Per Hour (mph)";
            this.mphButton.UseVisualStyleBackColor = true;
            this.mphButton.CheckedChanged += new System.EventHandler(this.val_Changed);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.val_Changed);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(12, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(209, 20);
            this.textBox2.TabIndex = 2;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(12, 94);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(68, 13);
            this.inputLabel.TabIndex = 3;
            this.inputLabel.Text = "Input Speed:";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(12, 144);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(76, 13);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "Output Speed:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 195);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.unitsGroup);
            this.MinimumSize = new System.Drawing.Size(249, 234);
            this.Name = "Form1";
            this.Text = "Speed Conversion";
            this.unitsGroup.ResumeLayout(false);
            this.unitsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox unitsGroup;
        private System.Windows.Forms.RadioButton kphButton;
        private System.Windows.Forms.RadioButton mphButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
    }
}

