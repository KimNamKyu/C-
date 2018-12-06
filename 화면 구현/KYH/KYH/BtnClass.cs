using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KYH
{
    class BtnClass
    {
        public void button(BtnSet btnSet)
        {
            Button button = new Button();
            button.DialogResult = DialogResult.OK;
            button.Size = new Size(btnSet.SizeX, btnSet.SizeY);
            button.Location = new Point(btnSet.PointX, btnSet.PointY);
            button.Image = (Bitmap)KYH.Properties.Resources.ResourceManager.GetObject(btnSet.ImageRoute);
            button.Cursor = Cursors.Hand;
            button.Click += btnSet.eventHandler;

            btnSet.Form.Controls.Add(button);
        }

        public void button1(BtnSet btnSet)
        {
            Button button = new Button();
            button.DialogResult = DialogResult.OK;
            button.Size = new Size(btnSet.SizeX, btnSet.SizeY);
            button.Location = new Point(btnSet.PointX, btnSet.PointY);
            button.BackColor = Color.Gainsboro;
            button.Text = btnSet.Text;

            button.Click += btnSet.eventHandler;

            btnSet.Form.Controls.Add(button);
        }
    }
}
