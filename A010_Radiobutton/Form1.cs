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
            string result = "국적 : ";

            if (rbkorea.Checked)
                result += "대한민국\n";
            else if (rbchina.Checked)
                result += "중국\n";
            else if (rbjapan.Checked)
                result += "일본\n";
            else if (rbothers.Checked)
                result += "그 외의 국가\n";

            ///if (rbmale.Checked)
            //    result += "성별 : 남자";
            //if (rbfemale.Checked)
            //    result += "성별 : 여자";

            if (checkedRB == remale)
                result += "성별 : 남자";
            else if (checkedRB == rbfemale)
                result += "성별 : 여자";

            MessageBox.Show(result, "제출");
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