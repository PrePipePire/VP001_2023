using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A020_formclock
{
    public partial class Form1 : Form
    {
        //필드 만들기
        private Graphics g;
        private bool aClockFlag = true;
        private Point center; //시계의 중심점
        private int radius; //시계의 반지름
        private int hourHand; //시침의 길이
        private int minHand; //분침의 길이
        private int secHand; //초침의 길이

        private const int clientSize = 450;
        private const int clockSize = 350;


        public Form1()
        {
            InitializeComponent();

            this.Text = "Form Clock by Taehun Kang";
            panel1.BackColor = Color.White;
            this.ClientSize = new Size(clientSize, clientSize + menuStrip1.Height); //Size(width, height)

            g = panel1.CreateGraphics();

            aClockSetting();
            TimerSetting();
        }

        private void TimerSetting()
        {
            Timer t = new Timer();
            t.Interval = 1000;
            t.Tick += T_tick;
            t.Start(); // t.Enable = true;
        }

        //1초에 한번씩 시계를 그려준다
        private void T_tick(object sender, EventArgs e)
        {
            panel1.Refresh();
            DateTime c = DateTime.Now; //c에 현재시간 저장
            if (aClockFlag == true) 
            {
                //시계판
                DrawFace();

                //시계바늘의 각도를 라디안으로 표현 *라디안 = Math.PI / 180
                double radHr = (c.Hour % 12 + c.Minute / 60.0) * 30 * Math.PI / 180;
                double radMin = (c.Minute + c.Second / 60.0) * 6 * Math.PI / 180;
                double radSec = c.Second * 6 * Math.PI / 180;

                DrawHands(radHr, radMin, radSec);

                //시계배꼽
                int coreSize = 32;
                Rectangle r = new Rectangle(center.X - coreSize / 2, center.Y - coreSize /2 , coreSize, coreSize);
                g.FillEllipse(Brushes.Gold, r);
                g.DrawEllipse(new Pen(Brushes.Green, 5), r);
            }
            else // 디지털시계
            {
                Font fDate = new Font("맑은 고딕", 12, FontStyle.Bold);
                Font fTime = new Font("맑은 고딕", 32, FontStyle.Bold | FontStyle.Italic);

                Brush bDate = Brushes.SkyBlue;
                Brush bTime = Brushes.SteelBlue;

                string date = DateTime.Now.ToString("D");
                string time = string.Format("{0:D2}:{1:D2}:{2:D2}", c.Hour, c.Minute, c.Second);

                Point pDate = new Point(120, 180);
                Point pTime = new Point(120, 210);
                g.DrawString(date, fDate, bDate, pDate);
                g.DrawString(time, fTime, bTime, pTime);
            }
        }

        // 각도를 받아서 시계바늘을 그리는 메소드
        private void DrawHands(double radHr, double radMin, double radSec)
        {
            DrawLine((int)(hourHand * Math.Sin(radHr)), (int)(hourHand * Math.Cos(radHr)), Brushes.RoyalBlue, 14);

            DrawLine((int)(minHand * Math.Sin(radMin)), (int)(minHand * Math.Cos(radMin)), Brushes.SkyBlue, 9);

            DrawLine((int)(secHand * Math.Sin(radSec)), (int)(secHand * Math.Cos(radSec)), Brushes.OrangeRed, 5);
        }

        private void DrawLine(int x, int y, Brush b, int t)
        {
            Pen p = new Pen(b, t);
            p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            g.DrawLine(p, center.X, center.Y, center.X + x, center.Y - y);

            
        }

        private void DrawFace()
        {
            Pen p = new Pen(Color.LightSteelBlue, 40);
            g.DrawEllipse(p, center.X - clockSize / 2, center.Y - clockSize / 2, clockSize, clockSize);

            //시간 위치 표시
            int dotSize = 12;

            for (int i  = 0; i < 360; i += 30)
            {
                int x = (int)(center.X + radius * Math.Sin(i * Math.PI / 180) - dotSize / 2);
                Console.WriteLine(x);
                int y = (int)(center.Y - radius * Math.Cos(i * Math.PI / 180) - dotSize / 2);
                Console.WriteLine(y);
                g.FillEllipse(Brushes.AliceBlue, x, y, dotSize, dotSize);
            }
        }

        //아날로그 시계 세팅
        private void aClockSetting()
        {
            center = new Point(clientSize / 2, clientSize / 2);
            radius = clockSize / 2;

            hourHand = (int)(radius * 0.5);
            minHand = (int)(radius * 0.7);
            secHand = (int)(radius * 0.85);
        }

        private void 아날로그ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aClockFlag = true;
        }

        private void 디지털ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aClockFlag = false;
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}