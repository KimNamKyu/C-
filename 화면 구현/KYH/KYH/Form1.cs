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
    public partial class Form1 : Form
    {
        BtnClass btnClass = new BtnClass();

        Panel panel1 = new Panel(); // 최적화
        Panel panel2 = new Panel(); // 관리
        Panel panel3 = new Panel(); // 삭제
        Panel panel4 = new Panel(); // PC상태

        public Form1()  // mdi
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.BackColor = Color.WhiteSmoke;

            //https://support.microsoft.com/ko-kr/help/319465/how-to-change-the-background-color-for-an-mdi-parent-form-in-visual-c
            MdiClient mdiClient;
            foreach (Control control in this.Controls)
            {
                try
                {
                    mdiClient = (MdiClient)control;

                    mdiClient.BackColor = this.BackColor;
                }
                catch (InvalidCastException) { }
            }

            Button_Load();
            Logo_Load();
            Panel1_Load();
        }

        private void Button1_Click(object o, EventArgs e)   // 최적화
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

            Panel1_Load();
        }

        private void Panel1_Load()
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;

            panel1.Location = new Point(111, 3);
            panel1.Size = new Size(650, 400);

            Controls.Add(panel1);
            panel1.Controls.Add(form2);
            form2.Show();
        }

        private void Button2_Click(object o, EventArgs e) // 관리
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;

            Panel2_Load();
        }

        private void Panel2_Load()
        {
            FormY formY = new FormY();
            formY.MdiParent = this;

            panel2.Location = new Point(111, 3);
            panel2.Size = new Size(650, 400);

            Controls.Add(panel2);
            panel2.Controls.Add(formY);
            formY.Show();
        }

        private void Button3_Click(object o, EventArgs e)  // 삭제
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;

            Panel3_Load();
        }

        private void Panel3_Load()
        {
            Form4 form4 = new Form4();
            form4.MdiParent = this;

            panel3.Location = new Point(111, 3);
            panel3.Size = new Size(650, 400);

            Controls.Add(panel3);
            panel3.Controls.Add(form4);
            form4.Show();
        }

        private void Button4_Click(object o, EventArgs e)  // PC상태
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;

            Panel4_Load();
        }

        private void Panel4_Load()
        {
            Form5 form5 = new Form5();
            form5.MdiParent = this;

            panel4.Location = new Point(111, 3);
            panel4.Size = new Size(650, 400);

            Controls.Add(panel4);
            panel4.Controls.Add(form5);
            form5.Show();
        }

        private void Button_Load()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(new BtnSet(this, 110, 90, 1, 0, "image1", Button1_Click));
            arrayList.Add(new BtnSet(this, 110, 90, 1, 90, "image2", Button2_Click));
            arrayList.Add(new BtnSet(this, 110, 90, 1, 180, "image3", Button3_Click));
            arrayList.Add(new BtnSet(this, 110, 90, 1, 270, "image4", Button4_Click));

            for (int i = 0; i < arrayList.Count; i++)
            {
                btnClass.button((BtnSet)arrayList[i]);
            }
        }

        private void Logo_Load()
        {
            PictureBox pictureBox = new PictureBox();

            pictureBox.Image = (Bitmap)KYH.Properties.Resources.ResourceManager.GetObject("logo1");
            pictureBox.Location = new Point(5, 400);
            pictureBox.Size = new Size(250, 300);

            Controls.Add(pictureBox);
        }
    }
}
