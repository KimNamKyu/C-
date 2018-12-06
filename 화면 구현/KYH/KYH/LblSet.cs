using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KYH
{
    class LblSet
    {
        Form form;
        string text;
        public Font font;
        int fontSize;
        FontStyle fontStyle;
        int pointX;
        int pointY;
        Color color;

        public LblSet(Form form, string text, string fontName, int fontSize, FontStyle fontStyle, int pointX, int pointY,Color color)
        {
            this.form = form;
            this.text = text;
            this.font = new Font(fontName, fontSize, fontStyle);
            this.fontSize = fontSize;
            this.fontStyle = fontStyle;
            this.pointX = pointX;
            this.pointY = pointY;
            this.color = color;
        }
        public Form Form
        {
            get
            {
                return form;
            }
        }

        public Color Color
        {
            get
            {
                return color;
            }
        }
        public string Text
        {
            get
            {
                return text;
            }
        }
        public int FontSize
        {
            get
            {
                return fontSize;
            }
        }
        public FontStyle FontStyle
        {
            get
            {
                return fontStyle;
            }
        }
        public int PointX
        {
            get
            {
                return pointX;
            }
        }
        public int PointY
        {
            get
            {
                return pointY;
            }
        }
    }
}
