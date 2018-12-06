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
    public partial class Form4 : Form
    {
        ArrayList col_list = new ArrayList();
        ArrayList item_list = new ArrayList();
        ArrayList col2_list = new ArrayList();
        ArrayList item2_list = new ArrayList();
        public Form4()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;

            BackColor = Color.WhiteSmoke;
            Load += Form4_Load;
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            TabControl tabControl1 = new TabControl();
            TabPage tabPage1 = new TabPage();
            TabPage tabPage2 = new TabPage();
            TabPage tabPage3 = new TabPage();

            tabControl1.Padding = new Point(22, 20);
            tabControl1.Controls.AddRange(new Control[] { tabPage1, tabPage2, tabPage3 });
            tabControl1.Size = new Size(600, 500);
            tabControl1.ShowToolTips = true;

            tabPage1.ToolTipText = "프로그램 삭제 탭입니다.";
            tabPage2.ToolTipText = "개인정보 삭제 탭입니다.";
            tabPage3.ToolTipText = "파일 강제삭제 탭입니다.";

            tabPage1.Text = "프로그램 삭제";
            tabPage2.Text = "개인정보 삭제";
            tabPage3.Text = "파일 강제삭제";

            tabPage1.BackColor = Color.WhiteSmoke;
            tabPage2.BackColor = Color.WhiteSmoke;
            tabPage3.BackColor = Color.WhiteSmoke;
            
            Modulecs mc = new Modulecs();
            ArrayList arr = new ArrayList();
            
            //탭페이지 안에 라벨 생성
            arr.Add(new tablb(tabPage1, "lb", "내 PC에 설치된 프로그램을 관리합니다.", 400, 20, 45, 20));
            arr.Add(new tablb(tabPage2, "lb", "컴퓨터나 인터넷 사용에 따른 사용기록과 목록을 삭제합니다.", 500, 20, 80, 20));
            arr.Add(new tablb(tabPage3, "lb", "액세스 거부가 되어 삭제되지 않는 파일을 강제로 삭제합니다.", 500, 20, 45, 20));
            
            //개인정보 탭
            arr.Add(new cbtab(tabPage2, "1", "열어본 페이지 목록 삭제", 150, 60, 100, 80));
            arr.Add(new cbtab(tabPage2, "2", "저장된 패스워드 삭제", 80, 60, 100, 130));
            arr.Add(new cbtab(tabPage2, "3", "URL 히스토리 삭제", 80, 60, 100, 180));
            arr.Add(new cbtab(tabPage2, "4", "실행 목록 삭제", 80, 60, 100, 230));
            arr.Add(new cbtab(tabPage2, "5", "최근 열어본 문서 목록 삭제", 80, 60, 300, 80));
            arr.Add(new cbtab(tabPage2, "6", "오피스 문서 기록 삭제", 80, 60, 300, 130));
            arr.Add(new cbtab(tabPage2, "7", "자동완성 목록 삭제", 80, 60, 300, 180));
            arr.Add(new cbtab(tabPage2, "8", "휴지통 비우기", 80, 60, 300, 230));

            //프로그램 삭제탭 리스트뷰 
            col_list.Add(new string[] { " ", "30" });
            col_list.Add(new string[] { "프로그램명", "180" });
            col_list.Add(new string[] { "제작사", "200" });
            col_list.Add(new string[] { "설치일", "100" });

            item_list.Add(new Items(new string[] { " ", "Chrom", " Google.inc ", "2018.09.17"}));
            item_list.Add(new Items(new string[] { " ", "HeidiSQL", "Ansgar Becker", " 2018.10.05"}));
            item_list.Add(new Items(new string[] { " ", "FileZilla Client 3.37.0", "Tim kosse", " 2018.10.23" }));

            //파일강제 삭제탭 리스트 뷰
            col2_list.Add(new string[] { " ", "30" });
            col2_list.Add(new string[] { "파일명", "480" });

            item2_list.Add(new Items2(new string[] { " ", "WindowsApp.exe" }));
            item2_list.Add(new Items2(new string[] { " ", "WindowsApp2.exe" }));
            

            ListView listView1 = lv_create(col_list, item_list);
            ListView listView2 = lv2_create(col2_list, item2_list);

            ClassY Cy = new ClassY(listView1, listView2);   

            //탭페이지 안에 버튼 생성
            arr.Add(new tabbtn(tabPage1, "btn_1", "삭제", 90, 50, 250, 280, Cy.btn1_Click));
            arr.Add(new tabbtn(tabPage2, "btn_2", "삭제", 90, 50, 250, 280, Cy.btn2_Click));
            arr.Add(new tabbtn(tabPage3, "btn_3", "삭제", 90, 50, 250, 280, Cy.btn1_Click));

            
            for (int i = 0; i < arr.Count; i++)
            {
                if (typeof(tabbtn) == arr[i].GetType())  
                {
                    mc.btn((tabbtn)arr[i]);
                }
                else if (typeof(tablb) == arr[i].GetType()) 
                {
                    mc.lb((tablb)arr[i]);
                }
                else if(typeof(cbtab) == arr[i].GetType())
                {
                    mc.cb((cbtab)arr[i]);
                }
            }

            tabPage1.Controls.Add(listView1);
            tabPage3.Controls.Add(listView2);
            Controls.AddRange(new Control[] { tabControl1 });
        }

        public ListView lv_create(ArrayList col_list, ArrayList item_list) //관리 리스트 뷰
        {
            ListView listView1 = new ListView();
            
            listView1.GridLines = true;
            listView1.Location = new Point(50, 70);
            listView1.CheckBoxes = true;
            listView1.GridLines = true;
            listView1.Name = "listView1";
            listView1.Size = new Size(500, 200);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.BackColor = Color.Gainsboro;
            listView1.ForeColor = Color.Black;


            bool I_check = Items_create(item_list, listView1);
            bool h_check = col_create(col_list, listView1);


            return listView1;
        }
        public ListView lv2_create(ArrayList col_list, ArrayList item_list) //관리 리스트 뷰
        {

            ListView listView2 = new ListView();

            listView2.GridLines = true;
            listView2.Location = new Point(50, 70);
            listView2.CheckBoxes = true;
            listView2.GridLines = true;
            listView2.Name = "listView1";
            listView2.Size = new Size(500, 200);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.BackColor = Color.Gainsboro;
            listView2.ForeColor = Color.Black;
            
            bool I2_check = Items2_create(item_list, listView2);
            bool h2_check = col2_create(col_list, listView2);
            
            return listView2;
        }

        private bool col_create(ArrayList col_list, ListView listView1)
        {
            for (int i = 0; i < col_list.Count; i++)
            {
                string[] arr = (string[])col_list[i]; //(string[]) 명시적 형변환
                ColumnHeader columnHeader = new ColumnHeader();
                columnHeader.Text = arr[0];
                columnHeader.Width = Convert.ToInt32(arr[1]);
                columnHeader.TextAlign = HorizontalAlignment.Center;
                listView1.Columns.Add(columnHeader);

            }
            return true;
        }
        private bool col2_create(ArrayList col2_list, ListView listView2)
        {
            for (int i = 0; i < col2_list.Count; i++)
            {
                string[] arr = (string[])col2_list[i]; //(string[]) 명시적 형변환
                ColumnHeader columnHeader = new ColumnHeader();
                columnHeader.Text = arr[0];
                columnHeader.Width = Convert.ToInt32(arr[1]);
                columnHeader.TextAlign = HorizontalAlignment.Left;
                listView2.Columns.Add(columnHeader);

            }
            return true;
        }

        private bool Items_create(ArrayList item_list, ListView listView1)
        {
            for (int i = 0; i < item_list.Count; i++)
            {
                Items row = (Items)item_list[i];
                ListViewItem item = new ListViewItem(row.getCol1());
                
                item.SubItems.Add(row.getCol2());
                item.SubItems.Add(row.getCol3());
                item.SubItems.Add(row.getCol4());
                listView1.Items.Add(item);
            }
            return true;
        }
        private bool Items2_create(ArrayList item2_list, ListView listView2)
        {
            for (int i = 0; i < item2_list.Count; i++)
            {
                Items2 row = (Items2)item2_list[i];
                ListViewItem item = new ListViewItem(row.getCol1());
                item.SubItems.Add(row.getCol2());
                listView2.Items.Add(item);
            }
            return true;
        }
    }
}
