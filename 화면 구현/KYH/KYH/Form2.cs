using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KYH
{
    public partial class Form2 : Form
    {
        BtnClass btnClass = new BtnClass();
        LblClass lblClass = new LblClass();

        Label label = new Label();
        Label label2 = new Label();
        Label label3 = new Label();
        Label label4 = new Label();

        Timer timer, timer1;
        Panel pan1, pan2,pan3, pan4, pan5, pan6;

        public Form2()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;

            BackColor = Color.WhiteSmoke;

            Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(new BtnSet(this,"하드디스크 최적화", 200, 80, 80, 80, BtnHard_Click));
            arrayList.Add(new BtnSet(this, "프로세스 최적화",200, 80, 80, 200, BtnProcess_Click));

            for (int i = 0; i < arrayList.Count; i++)
            {
                btnClass.button1((BtnSet)arrayList[i]);
            }

            ArrayList arrayList1 = new ArrayList();

            arrayList1.Add(new LblSet(this, "하드디스크", "고딕", 15, FontStyle.Bold, 370, 280, Color.Black));
            arrayList1.Add(new LblSet(this, "프로세스", "고딕", 15, FontStyle.Bold, 580, 280, Color.Black));

            for (int i = 0; i < arrayList1.Count; i++)
            {
                Control control = (lblClass.label((LblSet)arrayList1[i]));
                Controls.Add(lblClass.label((LblSet)arrayList1[i]));
            }

            label.AutoSize = true;
            label.Text = "75%";
            label.Font = new Font("고딕", 10, FontStyle.Bold);
            label.ForeColor = Color.Red;
            label.Location = new Point(396, 15+30);
            Controls.Add(label);

            label2.AutoSize = true;
            label2.Text = "45%";
            label2.Font = new Font("고딕", 10, FontStyle.Bold);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(600, 15 + 30);
            Controls.Add(label2);

            pan1 = new Panel();
            pan1.Height = 150+20;
            pan1.Width = 30;
            pan1.Location = new Point(400, 120 + 10);
            pan1.BackColor = Color.DarkBlue;

            pan2 = new Panel();
            pan2.Height = 150+20;
            pan2.Width = 30;
            pan2.Location = new Point(400, 120 + 10);
            pan2.BackColor = Color.DarkBlue;

            pan3 = new Panel();
            pan3.Height = 230;
            pan3.Width = 30;
            pan3.Location = new Point(400, 40 + 30);
            pan3.BackColor = Color.Silver;

            Controls.Add(pan1);
            Controls.Add(pan2);
            Controls.Add(pan3);

            pan4 = new Panel();
            pan4.Height = 110;
            pan4.Width = 30;
            pan4.Location = new Point(600, 170);
            pan4.BackColor = Color.DarkBlue;

            pan5 = new Panel();
            pan5.Height = 110;
            pan5.Width = 30;
            pan5.Location = new Point(600, 170);
            pan5.BackColor = Color.DarkBlue;

            pan6 = new Panel();
            pan6.Height = 230;
            pan6.Width = 30;
            pan6.Location = new Point(600, 40 + 30);
            pan6.BackColor = Color.Silver;

            Controls.Add(pan4);
            Controls.Add(pan5);
            Controls.Add(pan6);

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (pan1.Height > 100)
            {
                pan1.Height = 1;

            }
            else if (pan1.Height == 100)
            {
                timer.Stop();
                label3.AutoSize = true;
                label3.Text = "22%";
                label3.Font = new Font("고딕", 10, FontStyle.Bold);
                label3.ForeColor = Color.Red;
                label3.Location = new Point(396, 15 + 30);
                Controls.Add(label3);
            }
            else
            {
                pan1.Height = pan1.Height + 1;
                pan1.BackColor = Color.Silver;
            }
            
            //if (pan1.Height > 100) pan1.Height = 1;
            //else pan1.Height = pan1.Height + 1;

            timer.Start();
        }

        private void Timer_Tick1(object sender, EventArgs e)
        {
            if (pan4.Height > 99)
            {
                pan4.Height = 1;

            }
            else if (pan4.Height == 80)
            {
                timer1.Stop();

                label4.AutoSize = true;
                label4.Text = "10%";
                label4.Font = new Font("고딕", 10, FontStyle.Bold);
                label4.ForeColor = Color.Red;
                label4.Location = new Point(600, 15 + 30);
                Controls.Add(label4);
            }
            else
            {
                pan4.Height = pan4.Height + 1;
                pan4.BackColor = Color.Silver;
            }

            //if (pan1.Height > 100) pan1.Height = 1;
            //else pan1.Height = pan1.Height + 1;

            timer1.Start();
        }

        private void BtnHard_Click(object sender, EventArgs e)
        {
            
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
            timer.Start();

            label.Dispose();
            
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
           
            timer1 = new Timer();
            timer1.Interval = 20;
            timer1.Tick += Timer_Tick1;
            timer1.Start();

            label2.Dispose();
        }
    }
}
