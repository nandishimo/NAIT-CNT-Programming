
namespace LabExam1Q1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.multiplyRB = new System.Windows.Forms.RadioButton();
            this.addRB = new System.Windows.Forms.RadioButton();
            this.subtractRB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.value1Box = new System.Windows.Forms.TextBox();
            this.value2Box = new System.Windows.Forms.TextBox();
            this.resultsBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.subtractRB);
            this.groupBox1.Controls.Add(this.addRB);
            this.groupBox1.Controls.Add(this.multiplyRB);
            this.groupBox1.Location = new System.Drawing.Point(45, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Operation";
            // 
            // multiplyRB
            // 
            this.multiplyRB.AutoSize = true;
            this.multiplyRB.Location = new System.Drawing.Point(25, 47);
            this.multiplyRB.Name = "multiplyRB";
            this.multiplyRB.Size = new System.Drawing.Size(102, 17);
            this.multiplyRB.TabIndex = 0;
            this.multiplyRB.TabStop = true;
            this.multiplyRB.Text = "Value1 x Value2";
            this.multiplyRB.UseVisualStyleBackColor = true;
            this.multiplyRB.CheckedChanged += new System.EventHandler(this.valueChanged);
            // 
            // addRB
            // 
            this.addRB.AutoSize = true;
            this.addRB.Location = new System.Drawing.Point(25, 79);
            this.addRB.Name = "addRB";
            this.addRB.Size = new System.Drawing.Size(103, 17);
            this.addRB.TabIndex = 1;
            this.addRB.TabStop = true;
            this.addRB.Text = "Value1 + Value2";
            this.addRB.UseVisualStyleBackColor = true;
            this.addRB.CheckedChanged += new System.EventHandler(this.valueChanged);
            // 
            // subtractRB
            // 
            this.subtractRB.AutoSize = true;
            this.subtractRB.Location = new System.Drawing.Point(25, 113);
            this.subtractRB.Name = "subtractRB";
            this.subtractRB.Size = new System.Drawing.Size(100, 17);
            this.subtractRB.TabIndex = 2;
            this.subtractRB.TabStop = true;
            this.subtractRB.Text = "Value1 - Value2";
            this.subtractRB.UseVisualStyleBackColor = true;
            this.subtractRB.CheckedChanged += new System.EventHandler(this.valueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Value1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Value2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Results:";
            // 
            // value1Box
            // 
            this.value1Box.Location = new System.Drawing.Point(477, 93);
            this.value1Box.Name = "value1Box";
            this.value1Box.Size = new System.Drawing.Size(206, 20);
            this.value1Box.TabIndex = 4;
            this.value1Box.TextChanged += new System.EventHandler(this.valueChanged);
            // 
            // value2Box
            // 
            this.value2Box.Location = new System.Drawing.Point(477, 127);
            this.value2Box.Name = "value2Box";
            this.value2Box.Size = new System.Drawing.Size(206, 20);
            this.value2Box.TabIndex = 5;
            this.value2Box.TextChanged += new System.EventHandler(this.valueChanged);
            // 
            // resultsBox
            // 
            this.resultsBox.Location = new System.Drawing.Point(477, 161);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.ReadOnly = true;
            this.resultsBox.Size = new System.Drawing.Size(206, 20);
            this.resultsBox.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.value2Box);
            this.Controls.Add(this.value1Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "No of Milliseconds Elapsed: 0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton subtractRB;
        private System.Windows.Forms.RadioButton addRB;
        private System.Windows.Forms.RadioButton multiplyRB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox value1Box;
        private System.Windows.Forms.TextBox value2Box;
        private System.Windows.Forms.TextBox resultsBox;
        private System.Windows.Forms.Timer timer1;
    }
}

