using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A002_BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height = double.Parse(this.txtHeight.Text);
            double weight = double.Parse(txtWeight.Text);
            double bmi = weight / (height / 100 * height / 100);
            //lblBMI.Text = "BMI = " + bmi;
            lblBMI.Text = String.Format("BMI = {0}", bmi);

            if (bmi < 20)
            {
                lblresult.Text = "저체중";
                pictureBox1.BackColor = Color.Blue;
            }
            else if (bmi < 25)
            {
                lblresult.Text = "정상체중";
                pictureBox1.BackColor = Color.Green;
            }
            else if (bmi < 30)
            {
                lblresult.Text = "경도비만";
                pictureBox1.BackColor = Color.Orange;
            }
            else if (bmi < 40)
            {
                lblresult.Text = "비만";
                pictureBox1.BackColor = Color.Yellow;
            }
            else
            {
                lblresult.Text = "고도비만";
                pictureBox1.BackColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}