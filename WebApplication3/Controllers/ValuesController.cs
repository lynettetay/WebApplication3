using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public string Post([FromBody]Models.Results plate)
        {
            //using (System.IO.StreamWriter xW = new System.IO.StreamWriter(HttpRuntime.AppDomainAppPath + "\\123.txt"))
            //{
            //    xW.WriteLine(plate.plate);
            //} 
            return plate.plate;
            //string[] xDatas = xValue.Data.Split(",".ToCharArray());
            //string ss = xDatas[1].Remove(xDatas[1].Length - 1, 1);
            //byte[] xBuffer = Convert.FromBase64String(xDatas[1]);
            ////string sPath = "C:\\Users\\Presentation\\Documents\\image";
            //string sPath = System.Web.HttpContext.Current.Server.MapPath("~/WebApplication3//UploadedImages");
            //System.IO.File.WriteAllBytes($"{sPath}\\{DateTime.Now.Ticks}.jpg", xBuffer);

        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
