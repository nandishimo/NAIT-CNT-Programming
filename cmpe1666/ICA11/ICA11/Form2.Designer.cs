
namespace ICA11
{
    partial class ModelessColourForm
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
            this.UI_TBar_RED = new System.Windows.Forms.TrackBar();
            this.UI_TBar_GREEN = new System.Windows.Forms.TrackBar();
            this.UI_TBar_BLUE = new System.Windows.Forms.TrackBar();
            this.UI_GBow_RGB = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UI_TBar_OPACITY = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.UI_TBar_RED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_TBar_GREEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_TBar_BLUE)).BeginInit();
            this.UI_GBow_RGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_TBar_OPACITY)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_TBar_RED
            // 
            this.UI_TBar_RED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.UI_TBar_RED.Location = new System.Drawing.Point(5, 17);
            this.UI_TBar_RED.Maximum = 255;
            this.UI_TBar_RED.Name = "UI_TBar_RED";
            this.UI_TBar_RED.Size = new System.Drawing.Size(743, 45);
            this.UI_TBar_RED.TabIndex = 0;
            this.UI_TBar_RED.TickFrequency = 10;
            this.UI_TBar_RED.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.UI_TBar_RED.ValueChanged += new System.EventHandler(this.UI_TBar_ValueChanged);
            // 
            // UI_TBar_GREEN
            // 
            this.UI_TBar_GREEN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.UI_TBar_GREEN.Location = new System.Drawing.Point(5, 68);
            this.UI_TBar_GREEN.Maximum = 255;
            this.UI_TBar_GREEN.Name = "UI_TBar_GREEN";
            this.UI_TBar_GREEN.Size = new System.Drawing.Size(743, 45);
            this.UI_TBar_GREEN.TabIndex = 1;
            this.UI_TBar_GREEN.TickFrequency = 10;
            this.UI_TBar_GREEN.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.UI_TBar_GREEN.ValueChanged += new System.EventHandler(this.UI_TBar_ValueChanged);
            // 
            // UI_TBar_BLUE
            // 
            this.UI_TBar_BLUE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UI_TBar_BLUE.Location = new System.Drawing.Point(5, 119);
            this.UI_TBar_BLUE.Maximum = 255;
            this.UI_TBar_BLUE.Name = "UI_TBar_BLUE";
            this.UI_TBar_BLUE.Size = new System.Drawing.Size(743, 45);
            this.UI_TBar_BLUE.TabIndex = 2;
            this.UI_TBar_BLUE.TickFrequency = 10;
            this.UI_TBar_BLUE.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.UI_TBar_BLUE.ValueChanged += new System.EventHandler(this.UI_TBar_ValueChanged);
            // 
            // UI_GBow_RGB
            // 
            this.UI_GBow_RGB.Controls.Add(this.UI_TBar_BLUE);
            this.UI_GBow_RGB.Controls.Add(this.UI_TBar_GREEN);
            this.UI_GBow_RGB.Controls.Add(this.UI_TBar_RED);
            this.UI_GBow_RGB.Location = new System.Drawing.Point(12, 12);
            this.UI_GBow_RGB.Name = "UI_GBow_RGB";
            this.UI_GBow_RGB.Size = new System.Drawing.Size(757, 178);
            this.UI_GBow_RGB.TabIndex = 3;
            this.UI_GBow_RGB.TabStop = false;
            this.UI_GBow_RGB.Text = "Colour";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UI_TBar_OPACITY);
            this.groupBox1.Location = new System.Drawing.Point(12, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 104);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opacity";
            // 
            // UI_TBar_OPACITY
            // 
            this.UI_TBar_OPACITY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UI_TBar_OPACITY.Location = new System.Drawing.Point(9, 30);
            this.UI_TBar_OPACITY.Maximum = 100;
            this.UI_TBar_OPACITY.Name = "UI_TBar_OPACITY";
            this.UI_TBar_OPACITY.Size = new System.Drawing.Size(743, 45);
            this.UI_TBar_OPACITY.TabIndex = 1;
            this.UI_TBar_OPACITY.TickFrequency = 10;
            this.UI_TBar_OPACITY.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.UI_TBar_OPACITY.Value = 100;
            this.UI_TBar_OPACITY.ValueChanged += new System.EventHandler(this.UI_TBar_ValueChanged);
            // 
            // ModelessColourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 312);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UI_GBow_RGB);
            this.Name = "ModelessColourForm";
            this.Text = "Select Colour/Opacity";
            this.Load += new System.EventHandler(this.ModelessColourForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UI_TBar_RED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_TBar_GREEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_TBar_BLUE)).EndInit();
            this.UI_GBow_RGB.ResumeLayout(false);
            this.UI_GBow_RGB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_TBar_OPACITY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar UI_TBar_RED;
        private System.Windows.Forms.TrackBar UI_TBar_GREEN;
        private System.Windows.Forms.TrackBar UI_TBar_BLUE;
        private System.Windows.Forms.GroupBox UI_GBow_RGB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar UI_TBar_OPACITY;
    }
}