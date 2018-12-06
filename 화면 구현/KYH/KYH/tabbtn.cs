using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KYH
{
    class tabbtn
    {
        TabPage tabPage2;
        string name, text;
        int sX, sY, pX, pY;

        public tabbtn(TabPage tabPage2, string name, string text, int sX, int sY, int pX, int pY, EventHandler eh)
        {
            this.tabPage2 = tabPage2;
            this.name = name;
            this.text = text;
            this.sX = sX;
            this.sY = sY;
            this.pX = pX;
            this.pY = pY;
            this.eh = eh;
        }

        public EventHandler eh;
        public TabPage TabPage
        {
            get
            {
                return tabPage2;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Text
        {
            get
            {
                return text;
            }
        }
        public int SX
        {
            get
            {
                return sX;
            }
        }
        public int SY
        {
            get
            {
                return sY;
            }
        }
        public int PX
        {
            get
            {
                return pX;
            }
        }
        public int PY
        {
            get
            {
                return pY;
            }
        }
    }
}
