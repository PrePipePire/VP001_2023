namespace A004_Login
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
            lblID = new Label();
            lblPW = new Label();
            txtID = new TextBox();
            txtPW = new TextBox();
            btnLOGIN = new Button();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(50, 54);
            lblID.Name = "lblID";
            lblID.Size = new Size(43, 15);
            lblID.TabIndex = 0;
            lblID.Text = "아이디";
            // 
            // lblPW
            // 
            lblPW.AutoSize = true;
            lblPW.Location = new Point(50, 113);
            lblPW.Name = "lblPW";
            lblPW.Size = new Size(55, 15);
            lblPW.TabIndex = 1;
            lblPW.Text = "패스워드";
            // 
            // txtID
            // 
            txtID.Location = new Point(135, 54);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 2;
            // 
            // txtPW
            // 
            txtPW.Location = new Point(135, 113);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(100, 23);
            txtPW.TabIndex = 3;
            txtPW.UseSystemPasswordChar = true;
            // 
            // btnLOGIN
            // 
            btnLOGIN.Location = new Point(135, 200);
            btnLOGIN.Name = "btnLOGIN";
            btnLOGIN.Size = new Size(100, 30);
            btnLOGIN.TabIndex = 4;
            btnLOGIN.Text = "로그인";
            btnLOGIN.UseVisualStyleBackColor = true;
            btnLOGIN.Click += btnLOGIN_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(135, 287);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(100, 23);
            txtResult.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 450);
            Controls.Add(txtResult);
            Controls.Add(btnLOGIN);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(lblPW);
            Controls.Add(lblID);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label lblPW;
        private TextBox txtID;
        private TextBox txtPW;
        private Button btnLOGIN;
        private TextBox txtResult;
    }
}