namespace A004_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "abcd" && txtPW.Text == "1234")
                txtResult.Text = ("�α��� ����");
            else
                txtResult.Text = ("�α��� ����");
        }
    }
}