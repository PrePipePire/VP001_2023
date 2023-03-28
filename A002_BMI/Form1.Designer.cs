namespace A002_BMI
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
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblBMI = new Label();
            btnCal = new Button();
            lblresult = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(124, 56);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(100, 23);
            txtHeight.TabIndex = 0;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(124, 119);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(100, 23);
            txtWeight.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 65);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "키(cm)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 122);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "체중(kg)";
            // 
            // lblBMI
            // 
            lblBMI.AutoSize = true;
            lblBMI.Location = new Point(28, 253);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new Size(0, 15);
            lblBMI.TabIndex = 4;
            // 
            // btnCal
            // 
            btnCal.Location = new Point(139, 192);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(85, 25);
            btnCal.TabIndex = 5;
            btnCal.Text = "BMI";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += button1_Click;
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.Location = new Point(28, 324);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(0, 15);
            lblresult.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(157, 295);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 67);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 402);
            Controls.Add(pictureBox1);
            Controls.Add(lblresult);
            Controls.Add(btnCal);
            Controls.Add(lblBMI);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Name = "Form1";
            Text = "BMI 계산기";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHeight;
        private TextBox txtWeight;
        private Label label1;
        private Label label2;
        private Label lblBMI;
        private Button btnCal;
        private Label lblresult;
        private PictureBox pictureBox1;
    }
}