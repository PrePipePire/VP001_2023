using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;
using System.Security.Cryptography;

namespace A023_FIREBASE
{
    public partial class Form1 : Form
    {
        //row(열) - table(표) - set(표의 집합) 순으로 상위 개념
        DataTable dt = new DataTable();

        IFirebaseConfig config = new FirebaseConfig 
        {
            AuthSecret = "0zEMJT0ibw3Adjj8O6ox9GpUrUZByncftWDyu9Wa", //비밀번호 파이어베이스 서비스 계정에서 가져옴
            BasePath = "https://fir-kangtaehun-default-rtdb.firebaseio.com/" //경로 파이어베이스에서 링크 복사 
        };

        IFirebaseClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config); //파이어베이스에 접속 client = 데이터베이스
            if (client != null)
                MessageBox.Show("connecting 성공");

            dt.Columns.Add("Id");
            dt.Columns.Add("학번");
            dt.Columns.Add("이름");
            dt.Columns.Add("전화번호");

            dataGridView1.DataSource = dt;
        }


        //비동기 프로그램 (async ~ await)
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtSID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            FirebaseResponse responese = await client.GetAsync("VP_01 Phonebook/" + txtID.Text);
            //client(데이터베이스)에서 비동기식으로 값을 받아옴(VP_01 Phonebook아래에 txtID.Text이라는 이름의 데이터)
            Data obj = responese.ResultAs<Data>();
            //받아온 값을 obj에 저장

            txtID.Text = obj.Id;
            txtSID.Text = obj.SID;
            txtName.Text = obj.Name;
            txtPhone.Text = obj.txtPhone;
        }

        private async void btnInsert_Click(object sender, EventArgs e)
        {
            FirebaseResponse resp = await client.GetAsync("VP01_Counter/nPhones");
            Counter c = resp.ResultAs<Counter>();
            MessageBox.Show(c.cnt.ToString());

            var data = new Data
            {
                //Id = txtID.Text,
                Id = (c.cnt + 1).ToString(),
                SID = txtSID.Text,
                Name = txtName.Text,
                txtPhone = txtPhone.Text
            };
            //SetResponse response = await client.SetAsync("VP_01 Phonebook/" + txtID.Text, data);
            //client(데이터베이스)에서 비동기식으로 값을 세팅(VP_01 Phonebook아래에 txtID.Text이라는 이름으로 data 저장)
            SetResponse response = await client.SetAsync("VP_01 Phonebook/" + data.Id, data);


            Data result = response.ResultAs<Data>(); //reponse값이 제대로 들어갔는지 확인하기 위해 result애 저장
            MessageBox.Show("data inserted : id = " + result.Id);

            //counter 값을 증가시켜 firebase에 저장한다
            var obj = new Counter
            {
                cnt = c.cnt + 1
            };
            SetResponse r = await client.SetAsync("VP01_Counter/nPhones", obj);
            export();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                Id = txtID.Text,
                SID = txtSID.Text,
                Name = txtName.Text,
                txtPhone = txtPhone.Text
            };

            FirebaseResponse respones = await client.UpdateAsync("VP_01 Phonebook/" + txtID.Text, data);
            Data result = respones.ResultAs<Data>();

            MessageBox.Show("Data updated at : " + result.Id);
            export();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.DeleteAsync("VP_01 Phonebook/" + txtID.Text);

            Data result = response.ResultAs<Data>();
            MessageBox.Show("Data deleted at : " + txtID.Text);
            export();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            export();
        }

        private async void export()
        {
            dt.Rows.Clear();

            int i = 0;
            FirebaseResponse res = await client.GetAsync("VP01_Counter/nPhones");
            Counter obj = res.ResultAs<Counter>();

            int cnt = obj.cnt;

            while (i != cnt)
            {
                i++;
                FirebaseResponse resp = await client.GetAsync("VP_01 Phonebook/" + i);
                Data d = resp.ResultAs<Data>();

                //체크
                if ( d != null)
                {
                    DataRow row = dt.NewRow();
                    row["Id"] = d.Id;
                    row["학번"] = d.SID;
                    row["이름"] = d.Name;
                    row["전화번호"] = d.txtPhone;

                    dt.Rows.Add(row);
                }
            }
        }

        private async void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("저장된 데이터가 모두 삭제됩니다. 계속하시겠습니까?", 
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (answer == DialogResult.No)
                return;

            //firebase의 counter/cnt 값을 0으로 바꾼다
            var obj = new Counter
            {
                cnt = 0
            };

            SetResponse res = await client.SetAsync("VP01_Counter/nPhones", obj);
            FirebaseResponse response = await client.DeleteAsync("VP_01 Phonebook");

            dt.Rows.Clear();
            export();
            MessageBox.Show("All data deleted! \n/VP_01 Phonebook deleted!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            txtID.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSID.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtName.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPhone.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}