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
            MessageBox.Show("간단한 메시지박스");

            MessageBox.Show("그 다음 간단한 메시지박스", "title");

            DialogResult result = MessageBox.Show("배경색을 바꿀까요?", "question",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question); 

            if (result == DialogResult.Yes) 
                this.BackColor = Color.Aqua;
        }
    }
}