using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYH
{
    public class Items
    {
        string col1;
        string col2;
        string col3;
        string col4;

        public Items(string[] a)
        {
            col1 = a[0];
            col2 = a[1];
            col3 = a[2];
            col4 = a[3];
        }

        public string getCol1()
        {
            return col1;
        }
        public string getCol2()
        {
            return col2;
        }
        public string getCol3()
        {
            return col3;
        }
        public string getCol4()
        {
            return col4;
        }
    }   //프로그램 삭제 탭 리스트뷰 아이템
    public class Items2
    {
        string col1;
        string col2;

        public Items2(string[] a)
        {
            col1 = a[0];
            col2 = a[1];
        }

        public string getCol1()
        {
            return col1;
        }
        public string getCol2()
        {
            return col2;
        }

    }   //파일강제 삭제 탭 리스트뷰 아이템2

}
