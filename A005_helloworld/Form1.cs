namespace A005_helloworld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblhw.Text = "Hello World!";
            this.BackColor = Color.White;
        }

        private void lblhw_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.White)
            {
                this.BackColor = Color.Blue;
                lblhw.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                lblhw.ForeColor = Color.Black;
            }
        }
    }
}