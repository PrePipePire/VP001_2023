using System.Diagnostics.Eventing.Reader;

namespace A007_messagebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("������ �޽����ڽ�");

            MessageBox.Show("�� ���� ������ �޽����ڽ�", "title");

            DialogResult result = MessageBox.Show("������ �ٲܱ��?", "question",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question); 

            if (result == DialogResult.Yes) 
                this.BackColor = Color.Aqua;
        }
    }
}