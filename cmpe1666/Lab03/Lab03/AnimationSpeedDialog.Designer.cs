
namespace Lab03
{
    partial class AnimationSpeedDialog
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
            this.UI_tbar_Speed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UI_tbar_Speed)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_tbar_Speed
            // 
            this.UI_tbar_Speed.Location = new System.Drawing.Point(12, 31);
            this.UI_tbar_Speed.Maximum = 200;
            this.UI_tbar_Speed.Minimum = 10;
            this.UI_tbar_Speed.Name = "UI_tbar_Speed";
            this.UI_tbar_Speed.Size = new System.Drawing.Size(507, 45);
            this.UI_tbar_Speed.TabIndex = 0;
            this.UI_tbar_Speed.TickFrequency = 10;
            this.UI_tbar_Speed.Value = 10;
            this.UI_tbar_Speed.Scroll += new System.EventHandler(this.UI_tbar_Speed_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "10 ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "200 ms";
            // 
            // AnimationSpeedDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 115);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_tbar_Speed);
            this.Name = "AnimationSpeedDialog";
            this.Text = "AnimationSpeedDialog";
            ((System.ComponentModel.ISupportInitialize)(this.UI_tbar_Speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar UI_tbar_Speed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}