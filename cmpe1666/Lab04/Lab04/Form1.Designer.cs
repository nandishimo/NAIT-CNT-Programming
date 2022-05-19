
namespace Lab04
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
            this.components = new System.ComponentModel.Container();
            this.UI_TBox_Lines = new System.Windows.Forms.TextBox();
            this.UI_BTN_UndoLine = new System.Windows.Forms.Button();
            this.UI_BTN_UndoSegment = new System.Windows.Forms.Button();
            this.UI_BTN_Complex = new System.Windows.Forms.Button();
            this.UI_BTN_Color = new System.Windows.Forms.Button();
            this.UI_TBar_Thickness = new System.Windows.Forms.TrackBar();
            this.UI_LBL_Thickness = new System.Windows.Forms.Label();
            this.UI_TBar_Alpha = new System.Windows.Forms.TrackBar();
            this.UI_LBL_Alpha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.UI_TBar_Thickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_TBar_Alpha)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_TBox_Lines
            // 
            this.UI_TBox_Lines.Location = new System.Drawing.Point(12, 12);
            this.UI_TBox_Lines.Name = "UI_TBox_Lines";
            this.UI_TBox_Lines.ReadOnly = true;
            this.UI_TBox_Lines.Size = new System.Drawing.Size(252, 20);
            this.UI_TBox_Lines.TabIndex = 0;
            // 
            // UI_BTN_UndoLine
            // 
            this.UI_BTN_UndoLine.Location = new System.Drawing.Point(12, 38);
            this.UI_BTN_UndoLine.Name = "UI_BTN_UndoLine";
            this.UI_BTN_UndoLine.Size = new System.Drawing.Size(252, 23);
            this.UI_BTN_UndoLine.TabIndex = 1;
            this.UI_BTN_UndoLine.Text = "Undo Line...";
            this.UI_BTN_UndoLine.UseVisualStyleBackColor = true;
            this.UI_BTN_UndoLine.Click += new System.EventHandler(this.UI_BTN_UndoLine_Click);
            // 
            // UI_BTN_UndoSegment
            // 
            this.UI_BTN_UndoSegment.Location = new System.Drawing.Point(12, 67);
            this.UI_BTN_UndoSegment.Name = "UI_BTN_UndoSegment";
            this.UI_BTN_UndoSegment.Size = new System.Drawing.Size(252, 23);
            this.UI_BTN_UndoSegment.TabIndex = 2;
            this.UI_BTN_UndoSegment.Text = "Undo Segment";
            this.UI_BTN_UndoSegment.UseVisualStyleBackColor = true;
            this.UI_BTN_UndoSegment.Click += new System.EventHandler(this.UI_BTN_UndoSegment_Click);
            // 
            // UI_BTN_Complex
            // 
            this.UI_BTN_Complex.Location = new System.Drawing.Point(12, 96);
            this.UI_BTN_Complex.Name = "UI_BTN_Complex";
            this.UI_BTN_Complex.Size = new System.Drawing.Size(252, 23);
            this.UI_BTN_Complex.TabIndex = 3;
            this.UI_BTN_Complex.Text = "Reduce Complexity";
            this.UI_BTN_Complex.UseVisualStyleBackColor = true;
            this.UI_BTN_Complex.Click += new System.EventHandler(this.UI_BTN_Complex_Click);
            // 
            // UI_BTN_Color
            // 
            this.UI_BTN_Color.Location = new System.Drawing.Point(12, 125);
            this.UI_BTN_Color.Name = "UI_BTN_Color";
            this.UI_BTN_Color.Size = new System.Drawing.Size(252, 23);
            this.UI_BTN_Color.TabIndex = 4;
            this.UI_BTN_Color.Text = "Color";
            this.UI_BTN_Color.UseVisualStyleBackColor = true;
            this.UI_BTN_Color.Click += new System.EventHandler(this.UI_BTN_Color_Click);
            // 
            // UI_TBar_Thickness
            // 
            this.UI_TBar_Thickness.Location = new System.Drawing.Point(12, 154);
            this.UI_TBar_Thickness.Maximum = 255;
            this.UI_TBar_Thickness.Minimum = 1;
            this.UI_TBar_Thickness.Name = "UI_TBar_Thickness";
            this.UI_TBar_Thickness.Size = new System.Drawing.Size(252, 45);
            this.UI_TBar_Thickness.TabIndex = 5;
            this.UI_TBar_Thickness.TickFrequency = 10;
            this.UI_TBar_Thickness.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.UI_TBar_Thickness.Value = 1;
            this.UI_TBar_Thickness.Scroll += new System.EventHandler(this.UI_TBar_Thickness_Scroll);
            // 
            // UI_LBL_Thickness
            // 
            this.UI_LBL_Thickness.AutoSize = true;
            this.UI_LBL_Thickness.Location = new System.Drawing.Point(12, 186);
            this.UI_LBL_Thickness.Name = "UI_LBL_Thickness";
            this.UI_LBL_Thickness.Size = new System.Drawing.Size(68, 13);
            this.UI_LBL_Thickness.TabIndex = 6;
            this.UI_LBL_Thickness.Text = "Thickness: 1";
            // 
            // UI_TBar_Alpha
            // 
            this.UI_TBar_Alpha.Location = new System.Drawing.Point(12, 216);
            this.UI_TBar_Alpha.Maximum = 255;
            this.UI_TBar_Alpha.Minimum = 1;
            this.UI_TBar_Alpha.Name = "UI_TBar_Alpha";
            this.UI_TBar_Alpha.Size = new System.Drawing.Size(252, 45);
            this.UI_TBar_Alpha.TabIndex = 7;
            this.UI_TBar_Alpha.TickFrequency = 10;
            this.UI_TBar_Alpha.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.UI_TBar_Alpha.Value = 255;
            this.UI_TBar_Alpha.Scroll += new System.EventHandler(this.UI_TBar_Alpha_Scroll);
            // 
            // UI_LBL_Alpha
            // 
            this.UI_LBL_Alpha.AutoSize = true;
            this.UI_LBL_Alpha.Location = new System.Drawing.Point(12, 248);
            this.UI_LBL_Alpha.Name = "UI_LBL_Alpha";
            this.UI_LBL_Alpha.Size = new System.Drawing.Size(58, 13);
            this.UI_LBL_Alpha.TabIndex = 8;
            this.UI_LBL_Alpha.Text = "Alpha: 255";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.White;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 268);
            this.Controls.Add(this.UI_LBL_Alpha);
            this.Controls.Add(this.UI_TBar_Alpha);
            this.Controls.Add(this.UI_LBL_Thickness);
            this.Controls.Add(this.UI_TBar_Thickness);
            this.Controls.Add(this.UI_BTN_Color);
            this.Controls.Add(this.UI_BTN_Complex);
            this.Controls.Add(this.UI_BTN_UndoSegment);
            this.Controls.Add(this.UI_BTN_UndoLine);
            this.Controls.Add(this.UI_TBox_Lines);
            this.MaximumSize = new System.Drawing.Size(295, 307);
            this.MinimumSize = new System.Drawing.Size(295, 307);
            this.Name = "Form1";
            this.Text = "Lab04";
            ((System.ComponentModel.ISupportInitialize)(this.UI_TBar_Thickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_TBar_Alpha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_TBox_Lines;
        private System.Windows.Forms.Button UI_BTN_UndoLine;
        private System.Windows.Forms.Button UI_BTN_UndoSegment;
        private System.Windows.Forms.Button UI_BTN_Complex;
        private System.Windows.Forms.Button UI_BTN_Color;
        private System.Windows.Forms.TrackBar UI_TBar_Thickness;
        private System.Windows.Forms.Label UI_LBL_Thickness;
        private System.Windows.Forms.TrackBar UI_TBar_Alpha;
        private System.Windows.Forms.Label UI_LBL_Alpha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

