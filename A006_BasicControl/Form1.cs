namespace A006_BasicControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
                MessageBox.Show("이름을 입력하세요", "Warning");
            else
                lblresult.Text = txtname.Text + "님! 안녕하세요!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}