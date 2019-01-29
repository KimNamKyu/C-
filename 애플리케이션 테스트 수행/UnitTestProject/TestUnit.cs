using System;
using System.Data.SqlClient;
using DB;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class TestUnit
    {
        MSsql db = new MSsql();

        [TestMethod]
        public void testRead()
        {
                string sql = "select * from Member;";
                SqlDataReader sdr = db.Reader(sql);

                while (sdr.Read())
                {
                    string[] arr = new string[sdr.FieldCount];
                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        arr[i] = sdr.GetValue(i).ToString();
                        Console.WriteLine(sdr.GetValue(i).ToString());
                    }
                }
                sdr.Close();
        }


        [TestMethod]
        public void Connet()
        {
            if (db.status)
            {
                 Console.WriteLine("접속성공");
            }
            else
            {
                Console.WriteLine("접속실패");
            }
            Assert.AreEqual(true, db.status);
        }

        [TestMethod]
        public void ConnetClose()
        {
            Assert.AreEqual(true, db.ConnectionClose());
            if (db.status)
            {
                Console.WriteLine("디비연결 해제");
            }
            else
            {
                Console.WriteLine("디비연결 해제 실패");
            }
        }

       

        [TestMethod]
        public void InsertTest()
        {

            string sql = string.Format("insert into Member (mID, mPass, mName) values ('test','1234','추가 테스트 중');");
            Assert.AreEqual(true, db.NonQuery(sql));
            if (db.status)
            {
                db.NonQuery(sql);
                Console.WriteLine("추가 테스트 성공");
            }
            else
            {
                Console.WriteLine("추가 테스트 실패");
                
            }
        }

        [TestMethod]
        public void UpdateTest()
        {
            string sql = string.Format("update Member set mID = '테스트', mPass = 'Test', mName = 'TTest', modDate = getDate() where mNo = 1");
            Assert.AreEqual(true, db.NonQuery(sql));
            if (db.status)
            {
                db.NonQuery(sql);
                Console.WriteLine("수정 테스트 성공");
            }
            else
            {
                Console.WriteLine("수정 테스트 실패");
            }
        }

        [TestMethod]
        public void DeleteTest()
        {
            string sql = string.Format("update Member set delYn = 'Y' where mNo = 3");
            Assert.AreEqual(true, db.NonQuery(sql));
            if (db.status)
            {
                db.NonQuery(sql);
                Console.WriteLine("삭제 테스트 성공");
            }
            else
            {
                Console.WriteLine("삭제 테스트 실패");
            }
        }
    }
}
