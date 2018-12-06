using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KYH
{
    class LblClass
    {
        public Label label(LblSet lblSet)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = lblSet.font;
            label.Location = new Point(lblSet.PointX, lblSet.PointY);
            label.Text = lblSet.Text;
            label.ForeColor = lblSet.Color;
            return label;
        }
    }
}
