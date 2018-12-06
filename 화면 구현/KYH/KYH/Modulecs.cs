using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KYH
{
    class Modulecs  //tabControl button object
    {
        public void btn(tabbtn bb)
        {
            Button btn = new Button();
            btn.Name = bb.Name;
            btn.Text = bb.Text;
            btn.Size = new Size(bb.SX, bb.SY);
            btn.Location = new Point(bb.PX, bb.PY);
            btn.Cursor = Cursors.Hand;
            bb.TabPage.Controls.Add(btn);
            btn.Click += bb.eh;
        }
        public void lb(tablb lb)
        {
            Label label = new Label();
            label.Name = lb.Name;
            label.Text = lb.Text;
            label.Font = new Font("굴림", 15F, FontStyle.Regular,GraphicsUnit.Point, ((byte)(200)));
            label.Size = new Size(lb.SX, lb.SY);
            label.Location = new Point(lb.PX, lb.PY);
            lb.TabPage.Controls.Add(label);
        }
        public void cb(cbtab cb)
        {
            CheckBox checkBox1 = new CheckBox();
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(cb.PX,cb.PY);
            checkBox1.Size = new Size(cb.SX, cb.SY);
            checkBox1.Text = cb.Text;
            checkBox1.Cursor = Cursors.Hand;
            cb.TabPage.Controls.Add(checkBox1);
        }
    }
}

