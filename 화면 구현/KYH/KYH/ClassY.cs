using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KYH
{
    class ClassY
    {
        ListView lv;
        ListView lv2;
        ListView listView1;
        ListView listView2;
        CheckBox checkBox1;
        int num;
        
        public ClassY(ListView lv, ListView lv2, int num)
        {
            this.lv = lv;
            this.num = num;
            this.lv2 = lv2;
        }

        public ClassY(ListView listView1, ListView listView2)
        {
            this.listView1 = listView1;
            this.listView2 = listView2;
        }

        public void Btn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listitem in lv.Items)
            {
                if (lv.Items.Count > 0)
                {
                    for (int i = lv.Items.Count - 1; i >= 0; i--)

                    {
                        if (lv.Items[i].Checked == true)
                        {
                            lv.Items[i].SubItems[2].Text = "비활성화";
                        }
                    }
                }
            }
        }
        public void Btn2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listitem in lv.Items)
            {
                if (lv.Items.Count > 0)
                {
                    for (int i = lv.Items.Count - 1; i >= 0; i--)

                    {
                        if (lv.Items[i].Checked == true)
                        {
                            lv.Items[i].SubItems[2].Text = "활성화";
                        }
                    }
                }
            }
        }
        public void Btn3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listitem in lv2.Items)
            {
                if (lv2.Items.Count > 0)
                {
                    for (int i = lv2.Items.Count - 1; i >= 0; i--)

                    {
                        if (lv2.Items[i].Checked == true)
                        {
                            lv2.Items[i].SubItems[1].Text = "중지";
                        }
                    }
                }
            }
        }
        public void Btn4_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listitem in lv2.Items)
            {
                if (lv2.Items.Count > 0)
                {
                    for (int i = lv2.Items.Count - 1; i >= 0; i--)

                    {
                        if (lv2.Items[i].Checked == true)
                        {
                            lv2.Items[i].SubItems[1].Text = "실행";
                        }
                    }
                }
            }
        }
        public void btn1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listitem in listView1.Items)
            {
                if (listView1.Items.Count > 0)
                {
                    for (int i = listView1.Items.Count - 1; i >= 0; i--)
                    {
                        if (listView1.Items[i].Checked == true)
                        {
                            listView1.Items[i].Remove();
                        }
                    }
                }
            }
            foreach (ListViewItem listitem in listView2.Items)
            {
                if (listView2.Items.Count > 0)
                {
                    for (int i = listView2.Items.Count - 1; i >= 0; i--)
                    {
                        if (listView2.Items[i].Checked == true)
                        {
                            listView2.Items[i].Remove();
                        }
                    }
                }
            }
        }
        public void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("삭제 완료 되었습니다.");
        }
    }
}

