namespace A011_SCORECAL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gb1 = new GroupBox();
            txteng = new TextBox();
            txtmath = new TextBox();
            txtkr = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gb2 = new GroupBox();
            txtavg = new TextBox();
            txtsum = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btncalc = new Button();
            gb1.SuspendLayout();
            gb2.SuspendLayout();
            SuspendLayout();
            // 
            // gb1
            // 
            gb1.Controls.Add(txteng);
            gb1.Controls.Add(txtmath);
            gb1.Controls.Add(txtkr);
            gb1.Controls.Add(label3);
            gb1.Controls.Add(label2);
            gb1.Controls.Add(label1);
            gb1.Location = new Point(44, 44);
            gb1.Name = "gb1";
            gb1.Size = new Size(184, 166);
            gb1.TabIndex = 0;
            gb1.TabStop = false;
            gb1.Text = "성적입력";
            // 
            // txteng
            // 
            txteng.Location = new Point(61, 122);
            txteng.Name = "txteng";
            txteng.Size = new Size(106, 23);
            txteng.TabIndex = 5;
            txteng.TextAlign = HorizontalAlignment.Center;
            // 
            // txtmath
            // 
            txtmath.Location = new Point(61, 75);
            txtmath.Name = "txtmath";
            txtmath.Size = new Size(106, 23);
            txtmath.TabIndex = 4;
            txtmath.TextAlign = HorizontalAlignment.Center;
            // 
            // txtkr
            // 
            txtkr.Location = new Point(61, 29);
            txtkr.Name = "txtkr";
            txtkr.Size = new Size(106, 23);
            txtkr.TabIndex = 3;
            txtkr.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 125);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "영어";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 78);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "수학";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 32);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "국어";
            // 
            // gb2
            // 
            gb2.Controls.Add(txtavg);
            gb2.Controls.Add(txtsum);
            gb2.Controls.Add(label5);
            gb2.Controls.Add(label4);
            gb2.Location = new Point(306, 44);
            gb2.Name = "gb2";
            gb2.Size = new Size(230, 165);
            gb2.TabIndex = 1;
            gb2.TabStop = false;
            gb2.Text = "결과";
            // 
            // txtavg
            // 
            txtavg.BackColor = SystemColors.Menu;
            txtavg.BorderStyle = BorderStyle.FixedSingle;
            txtavg.Location = new Point(94, 102);
            txtavg.Name = "txtavg";
            txtavg.ReadOnly = true;
            txtavg.Size = new Size(100, 23);
            txtavg.TabIndex = 3;
            txtavg.TextAlign = HorizontalAlignment.Center;
            // 
            // txtsum
            // 
            txtsum.BackColor = SystemColors.Menu;
            txtsum.BorderStyle = BorderStyle.FixedSingle;
            txtsum.Location = new Point(94, 53);
            txtsum.Name = "txtsum";
            txtsum.ReadOnly = true;
            txtsum.Size = new Size(100, 23);
            txtsum.TabIndex = 2;
            txtsum.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 102);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 1;
            label5.Text = "평균";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 56);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 0;
            label4.Text = "총점";
            // 
            // btncalc
            // 
            btncalc.Location = new Point(400, 236);
            btncalc.Name = "btncalc";
            btncalc.Size = new Size(117, 43);
            btncalc.TabIndex = 2;
            btncalc.Text = "계산";
            btncalc.UseVisualStyleBackColor = true;
            btncalc.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 325);
            Controls.Add(btncalc);
            Controls.Add(gb2);
            Controls.Add(gb1);
            Name = "Form1";
            Text = "성적계산기";
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            gb2.ResumeLayout(false);
            gb2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb1;
        private TextBox txteng;
        private TextBox txtmath;
        private TextBox txtkr;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox gb2;
        private Label label5;
        private Label label4;
        private Button btncalc;
        private TextBox txtavg;
        private TextBox txtsum;
    }
}