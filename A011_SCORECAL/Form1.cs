namespace A011_SCORECAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = Convert.ToDouble(txtkr.Text) + Convert.ToDouble(txteng.Text)
                + Convert.ToDouble(txtmath.Text); ;

            double avg = sum / 3;

            txtsum.Text = sum.ToString();
            txtavg.Text = avg.ToString("0.0");

            //double kr = double.Parse(txtkr.Text);
            //double math = double.Parse(txtmath.Text);
            //double eng = double.Parse(txteng.Text);

            //double sum = kr + math + eng
            //double avg = sum / 3
        }
    }
}