namespace A010_Radiobutton
{
    public partial class Radiobutton : Form
    {
        Radiobutton checkedRB;
        public Radiobutton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "���� : ";

            if (rbkorea.Checked)
                result += "���ѹα�\n";
            else if (rbchina.Checked)
                result += "�߱�\n";
            else if (rbjapan.Checked)
                result += "�Ϻ�\n";
            else if (rbothers.Checked)
                result += "�� ���� ����\n";

            ///if (rbmale.Checked)
            //    result += "���� : ����";
            //if (rbfemale.Checked)
            //    result += "���� : ����";

            if (checkedRB == remale)
                result += "���� : ����";
            else if (checkedRB == rbfemale)
                result += "���� : ����";

            MessageBox.Show(result, "����");
        }

        private void rbmale_CheckedChanged(object sender, EventArgs e)
        {
            checkedRB = rbmale;
        }

        private void rbfemale_CheckedChanged(object sender, EventArgs e)
        {
            checkedRB = rbfemale;
        }
    }
}