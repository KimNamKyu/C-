using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Module;

namespace Service.Controllers
{

    [ApiController]
    public class ServiceController : ControllerBase
    {

        [Route("select")]
        [HttpGet]
        public ActionResult<ArrayList> select()
        {
            Database db = new Database();
            SqlDataReader sdr = db.Reader("sp_Sproc");
            ArrayList list = new ArrayList();
            while(sdr.Read())
            {
                string[] arr = new string[6];
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    arr[i] = sdr.GetValue(i).ToString();
                }
                list.Add(arr);
            }
            db.ReaderClose(sdr);
            
            return list;
        }

        [Route("insert")]
        [HttpPost]
        public ActionResult<string> insert([FromForm] string nTitle, [FromForm]string nContent, [FromForm]string uName, [FromForm]string uPasswd)
        {
            System.Console.WriteLine("Insert");
            Hashtable ht = new Hashtable();
            ht.Add("@nTitle",nTitle);
            ht.Add("@nContent",nContent);
            ht.Add("@uName",uName);
            ht.Add("@uPasswd",uPasswd);
            Database db = new Database();
            if(db.NonQuery("spInproc",ht))
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }
         [Route("update")]
        [HttpPost]
        public ActionResult<string> update([FromForm] string nTitle, [FromForm]string nContent, [FromForm] string uName, [FromForm] string nNo)
        {
            System.Console.WriteLine("update");
            
            Hashtable ht = new Hashtable();
            ht.Add("@nTitle",nTitle);
            ht.Add("@nContent",nContent);
            ht.Add("@uName",uName);
            ht.Add("@nNo",nNo);
            Database db = new Database();
            if(db.NonQuery("sp_Uproc",ht))
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }

         [Route("delete")]
        [HttpPost]
        public ActionResult<string> delete([FromForm] string nNo)
        {
            System.Console.WriteLine("sp_Dproc");
            
            Hashtable ht = new Hashtable();
            ht.Add("@nNo",nNo);
           
            Database db = new Database();
            if(db.NonQuery("sp_delete",ht))
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }
    }
}
