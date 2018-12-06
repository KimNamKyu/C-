using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KYH
{
    class PictureboxClass
    {
        public void pictureBox(PictureboxSet pictureboxSet)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = (Bitmap)KYH.Properties.Resources.ResourceManager.GetObject(pictureboxSet.ImageRoute);
            pictureBox.Location = new Point(pictureboxSet.PointX, pictureboxSet.PointY);
            pictureBox.Size = new Size(pictureboxSet.SizeX, pictureboxSet.SizeY);
            pictureboxSet.Form.Controls.Add(pictureBox);
        }

    }
}
