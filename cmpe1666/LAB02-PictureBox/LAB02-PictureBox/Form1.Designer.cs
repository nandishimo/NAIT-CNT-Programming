
namespace LAB02_PictureBox
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noiseButton = new System.Windows.Forms.RadioButton();
            this.tintButton = new System.Windows.Forms.RadioButton();
            this.bwButton = new System.Windows.Forms.RadioButton();
            this.contrastButton = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.loadButton = new System.Windows.Forms.Button();
            this.transformButton = new System.Windows.Forms.Button();
            this.adjustSlider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adjustSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.noiseButton);
            this.groupBox1.Controls.Add(this.tintButton);
            this.groupBox1.Controls.Add(this.bwButton);
            this.groupBox1.Controls.Add(this.contrastButton);
            this.groupBox1.Location = new System.Drawing.Point(116, 440);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modification Type";
            // 
            // noiseButton
            // 
            this.noiseButton.AutoSize = true;
            this.noiseButton.Location = new System.Drawing.Point(98, 39);
            this.noiseButton.Name = "noiseButton";
            this.noiseButton.Size = new System.Drawing.Size(52, 17);
            this.noiseButton.TabIndex = 3;
            this.noiseButton.TabStop = true;
            this.noiseButton.Text = "Noise";
            this.noiseButton.UseVisualStyleBackColor = true;
            // 
            // tintButton
            // 
            this.tintButton.AutoSize = true;
            this.tintButton.Location = new System.Drawing.Point(98, 16);
            this.tintButton.Name = "tintButton";
            this.tintButton.Size = new System.Drawing.Size(43, 17);
            this.tintButton.TabIndex = 2;
            this.tintButton.TabStop = true;
            this.tintButton.Text = "Tint";
            this.tintButton.UseVisualStyleBackColor = true;
            // 
            // bwButton
            // 
            this.bwButton.AutoSize = true;
            this.bwButton.Location = new System.Drawing.Point(6, 39);
            this.bwButton.Name = "bwButton";
            this.bwButton.Size = new System.Drawing.Size(86, 17);
            this.bwButton.TabIndex = 1;
            this.bwButton.TabStop = true;
            this.bwButton.Text = "Black & White";
            this.bwButton.UseVisualStyleBackColor = true;
            // 
            // contrastButton
            // 
            this.contrastButton.AutoSize = true;
            this.contrastButton.Location = new System.Drawing.Point(6, 16);
            this.contrastButton.Name = "contrastButton";
            this.contrastButton.Size = new System.Drawing.Size(64, 17);
            this.contrastButton.TabIndex = 0;
            this.contrastButton.TabStop = true;
            this.contrastButton.Text = "Contrast";
            this.contrastButton.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 418);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 16);
            this.progressBar1.TabIndex = 3;
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadButton.Location = new System.Drawing.Point(12, 440);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(98, 30);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Load Picture";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // transformButton
            // 
            this.transformButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.transformButton.Location = new System.Drawing.Point(690, 440);
            this.transformButton.Name = "transformButton";
            this.transformButton.Size = new System.Drawing.Size(98, 30);
            this.transformButton.TabIndex = 5;
            this.transformButton.Text = "Transform";
            this.transformButton.UseVisualStyleBackColor = true;
            // 
            // adjustSlider
            // 
            this.adjustSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adjustSlider.Location = new System.Drawing.Point(280, 440);
            this.adjustSlider.Maximum = 20;
            this.adjustSlider.Name = "adjustSlider";
            this.adjustSlider.Size = new System.Drawing.Size(404, 45);
            this.adjustSlider.TabIndex = 6;
            this.adjustSlider.Value = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "left";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "right";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adjustSlider);
            this.Controls.Add(this.transformButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adjustSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton noiseButton;
        private System.Windows.Forms.RadioButton tintButton;
        private System.Windows.Forms.RadioButton bwButton;
        private System.Windows.Forms.RadioButton contrastButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button transformButton;
        private System.Windows.Forms.TrackBar adjustSlider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

