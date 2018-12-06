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
    public partial class Form5 : Form
    {
        LblClass lblClass = new LblClass();
        BtnClass btnClass = new BtnClass();
        PictureboxClass pictureboxClass = new PictureboxClass();

        public Form5()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;

            BackColor = Color.WhiteSmoke;

            Load += Form5_Load;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Label_Load();
            Labelhelp_Load();
            Picturebox_Load();
        }

        private void Label_Load()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(new LblSet(this, "━━ 하드디스크상태 ━━", "고딕", 20, FontStyle.Bold, 70, 40, Color.Black));
            arrayList.Add(new LblSet(this, "29도", "굴림", 13, FontStyle.Bold, 150, 100, Color.Red));
            arrayList.Add(new LblSet(this, "사용시간 : 898", "굴림", 13, FontStyle.Bold, 150, 210, Color.Black));
            arrayList.Add(new LblSet(this, "컴퓨터 켠 횟수 : 1024", "굴림", 13, FontStyle.Bold, 150, 320, Color.Black));
            arrayList.Add(new LblSet(this, "━━ CPU 온도 ━━", "고딕", 18, FontStyle.Bold, 430, 40, Color.Black));
            arrayList.Add(new LblSet(this, "32도", "굴림", 13, FontStyle.Bold, 500, 100, Color.Red));
            arrayList.Add(new LblSet(this, "━ 그래픽카드 온도 ━", "고딕", 20, FontStyle.Bold, 420, 220, Color.Black));
            arrayList.Add(new LblSet(this, "36도", "굴림", 13, FontStyle.Bold, 500, 290, Color.Red));

            for (int i = 0; i < arrayList.Count; i++)
            {
                Control control = (lblClass.label((LblSet)arrayList[i]));
                Controls.Add(lblClass.label((LblSet)arrayList[i]));
            }
        }

        private void Labelhelp_Load()
        {
            Label Label1 = new Label();
            ToolTip toolTip1 = new ToolTip();
            Label1.AutoSize = true;
            Label1.Text = "?";
            Label1.Cursor = Cursors.Help;
            Label1.Font = new Font("고딕", 10, FontStyle.Bold);
            Label1.Location = new Point(195, 102);
            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(Label1, "0  ~ 50도 : 적정온도 \n51 ~ 60도 : 약간 높은 상태\n60도 이상 : 위험한 상태로 백업 요망");
            Controls.Add(Label1);

            Label Label2 = new Label();
            ToolTip toolTip2 = new ToolTip();
            Label2.AutoSize = true;
            Label2.Text = "?";
            Label2.Cursor = Cursors.Help;
            Label2.Font = new Font("고딕", 10, FontStyle.Bold);
            Label2.Location = new Point(285, 212);
            toolTip2.IsBalloon = true;
            toolTip2.SetToolTip(Label2, "하드디스크의 평균 수명은 약 25만 시간");
            Controls.Add(Label2);

            Label Label3 = new Label();
            ToolTip toolTip3 = new ToolTip();
            Label3.AutoSize = true;
            Label3.Text = "?";
            Label3.Cursor = Cursors.Help;
            Label3.Font = new Font("고딕", 10, FontStyle.Bold);
            Label3.Location = new Point(347, 321);
            toolTip3.IsBalloon = true;
            toolTip3.ShowAlways = true;
            toolTip3.SetToolTip(Label3, "컴퓨터에 파워 들어온 횟수");
            Controls.Add(Label3);

            Label Label4 = new Label();
            ToolTip toolTip4 = new ToolTip();
            Label4.AutoSize = true;
            Label4.Text = "?";
            Label4.Cursor = Cursors.Help;
            Label4.Font = new Font("고딕", 10, FontStyle.Bold);
            Label4.Location = new Point(545, 101);
            toolTip4.IsBalloon = true;
            toolTip4.ShowAlways = true;
            toolTip4.SetToolTip(Label4, "0  ~ 55도 : 적정온도 \n56 ~ 65도 : 약간 높은 상태\n66 ~ 80 : 높은상태");
            Controls.Add(Label4);

            Label Label5 = new Label();
            ToolTip toolTip5 = new ToolTip();
            Label5.AutoSize = true;
            Label5.Text = "?";
            Label5.Cursor = Cursors.Help;
            Label5.Font = new Font("고딕", 10, FontStyle.Bold);
            Label5.Location = new Point(545, 292);
            toolTip5.IsBalloon = true;
            toolTip5.ShowAlways = true;
            toolTip5.SetToolTip(Label5, "0  ~ 55도 : 적정온도 \n56 ~ 65도 : 약간 높은 상태\n66 ~ 80 : 높은상태");
            Controls.Add(Label5);
        }

        private void Picturebox_Load()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(new PictureboxSet(this, 70, 80, 55, 95, "temperature")); // 하드디스크 온도
            arrayList.Add(new PictureboxSet(this, 80, 80, 55, 200, "time")); // 사용 시간
            arrayList.Add(new PictureboxSet(this, 80, 80, 55, 310, "reload")); // 컴퓨터 켠 횟수
            arrayList.Add(new PictureboxSet(this, 70, 80, 420, 95, "temperature")); // CPU온도
            arrayList.Add(new PictureboxSet(this, 70, 80, 420, 280, "temperature"));    // 그래픽카드 온도

            for (int i = 0; i < arrayList.Count; i++)
            {
                pictureboxClass.pictureBox((PictureboxSet)arrayList[i]);
            }
        }
    }
}

