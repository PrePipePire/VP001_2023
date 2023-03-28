namespace A006_BasicControl
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
            lblname = new Label();
            txtname = new TextBox();
            btnprint = new Button();
            lblresult = new Label();
            SuspendLayout();
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(61, 91);
            lblname.Name = "lblname";
            lblname.Size = new Size(38, 15);
            lblname.TabIndex = 0;
            lblname.Text = "이름 :";
            // 
            // txtname
            // 
            txtname.Location = new Point(120, 91);
            txtname.Name = "txtname";
            txtname.Size = new Size(119, 23);
            txtname.TabIndex = 1;
            // 
            // btnprint
            // 
            btnprint.Location = new Point(261, 82);
            btnprint.Name = "btnprint";
            btnprint.Size = new Size(123, 38);
            btnprint.TabIndex = 2;
            btnprint.Text = "출력";
            btnprint.UseVisualStyleBackColor = true;
            btnprint.Click += btnprint_Click;
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.Location = new Point(129, 160);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(0, 15);
            lblresult.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 284);
            Controls.Add(lblresult);
            Controls.Add(btnprint);
            Controls.Add(txtname);
            Controls.Add(lblname);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblname;
        private TextBox txtname;
        private Button btnprint;
        private Label lblresult;
    }
}