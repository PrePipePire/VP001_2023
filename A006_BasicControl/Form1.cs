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
                MessageBox.Show("�̸��� �Է��ϼ���", "Warning");
            else
                lblresult.Text = txtname.Text + "��! �ȳ��ϼ���!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}