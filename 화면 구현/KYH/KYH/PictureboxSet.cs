using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KYH
{
    class PictureboxSet
    {
        Form form;
        string imageRoute;
        int pointX;
        int pointY;
        int sizeX;
        int sizeY;

        public PictureboxSet(Form form, int sizeX, int sizeY, int pointX, int pointY, string imageRoute)
        {
            this.form = form;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            this.pointX = pointX;
            this.pointY = pointY;
            this.imageRoute = imageRoute;
        }

        public string ImageRoute { get => imageRoute;}
        public int PointX { get => pointX;}
        public int PointY { get => pointY;}
        public int SizeX { get => sizeX;}
        public int SizeY { get => sizeY;}
        public Form Form { get => form;}
    }
}
