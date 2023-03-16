namespace A010_Radiobutton
{
    partial class Radiobutton
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
            gbnation = new GroupBox();
            rbothers = new RadioButton();
            rbjapan = new RadioButton();
            rbchina = new RadioButton();
            rbkorea = new RadioButton();
            gbgender = new GroupBox();
            rbfemale = new RadioButton();
            rbmale = new RadioButton();
            button1 = new Button();
            gbnation.SuspendLayout();
            gbgender.SuspendLayout();
            SuspendLayout();
            // 
            // gbnation
            // 
            gbnation.Controls.Add(rbothers);
            gbnation.Controls.Add(rbjapan);
            gbnation.Controls.Add(rbchina);
            gbnation.Controls.Add(rbkorea);
            gbnation.Location = new Point(28, 50);
            gbnation.Name = "gbnation";
            gbnation.Size = new Size(379, 171);
            gbnation.TabIndex = 0;
            gbnation.TabStop = false;
            gbnation.Text = "국적";
            // 
            // rbothers
            // 
            rbothers.AutoSize = true;
            rbothers.Location = new Point(8, 115);
            rbothers.Name = "rbothers";
            rbothers.Size = new Size(93, 19);
            rbothers.TabIndex = 3;
            rbothers.TabStop = true;
            rbothers.Text = "그 외의 국가";
            rbothers.UseVisualStyleBackColor = true;
            // 
            // rbjapan
            // 
            rbjapan.AutoSize = true;
            rbjapan.Location = new Point(8, 90);
            rbjapan.Name = "rbjapan";
            rbjapan.Size = new Size(49, 19);
            rbjapan.TabIndex = 2;
            rbjapan.TabStop = true;
            rbjapan.Text = "일본";
            rbjapan.UseVisualStyleBackColor = true;
            // 
            // rbchina
            // 
            rbchina.AutoSize = true;
            rbchina.Location = new Point(8, 65);
            rbchina.Name = "rbchina";
            rbchina.Size = new Size(49, 19);
            rbchina.TabIndex = 1;
            rbchina.TabStop = true;
            rbchina.Text = "중국";
            rbchina.UseVisualStyleBackColor = true;
            // 
            // rbkorea
            // 
            rbkorea.AutoSize = true;
            rbkorea.Location = new Point(8, 40);
            rbkorea.Name = "rbkorea";
            rbkorea.Size = new Size(73, 19);
            rbkorea.TabIndex = 0;
            rbkorea.TabStop = true;
            rbkorea.Text = "대한민국";
            rbkorea.UseVisualStyleBackColor = true;
            // 
            // gbgender
            // 
            gbgender.Controls.Add(rbfemale);
            gbgender.Controls.Add(rbmale);
            gbgender.Location = new Point(474, 50);
            gbgender.Name = "gbgender";
            gbgender.Size = new Size(207, 100);
            gbgender.TabIndex = 1;
            gbgender.TabStop = false;
            gbgender.Text = "성별";
            // 
            // rbfemale
            // 
            rbfemale.AutoSize = true;
            rbfemale.Location = new Point(140, 31);
            rbfemale.Name = "rbfemale";
            rbfemale.Size = new Size(37, 19);
            rbfemale.TabIndex = 1;
            rbfemale.TabStop = true;
            rbfemale.Text = "여";
            rbfemale.UseVisualStyleBackColor = true;
            rbfemale.CheckedChanged += rbfemale_CheckedChanged;
            // 
            // rbmale
            // 
            rbmale.AutoSize = true;
            rbmale.Location = new Point(16, 33);
            rbmale.Name = "rbmale";
            rbmale.Size = new Size(37, 19);
            rbmale.TabIndex = 0;
            rbmale.TabStop = true;
            rbmale.Text = "남";
            rbmale.UseVisualStyleBackColor = true;
            rbmale.CheckedChanged += rbmale_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(540, 188);
            button1.Name = "button1";
            button1.Size = new Size(141, 33);
            button1.TabIndex = 2;
            button1.Text = "제출";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Radiobutton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 298);
            Controls.Add(button1);
            Controls.Add(gbgender);
            Controls.Add(gbnation);
            Name = "Radiobutton";
            Text = "Radiobutton";
            gbnation.ResumeLayout(false);
            gbnation.PerformLayout();
            gbgender.ResumeLayout(false);
            gbgender.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbnation;
        private RadioButton rbothers;
        private RadioButton rbjapan;
        private RadioButton rbchina;
        private RadioButton rbkorea;
        private GroupBox gbgender;
        private RadioButton rbfemale;
        private RadioButton rbmale;
        private Button button1;
    }
}