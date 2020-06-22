using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Web.Configuration;
using System.Web.Mvc;

namespace FermeWeb1._0.Controllers
{
    public class HerramientasController : Controller
    {
        public string calling(string url)
        {
            string uri = ConfigurationManager.AppSettings["urls"].ToString();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri + url);
            request.Method = "POST";
            request.ContentType = "application/json";
            string respuesta = "";
            try
            {
                WebResponse webResponse = request.GetResponse();
                Stream webStream = webResponse.GetResponseStream();
                StreamReader responseReader = new StreamReader(webStream);
                respuesta = responseReader.ReadToEnd();
                responseReader.Close();
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
            }
            return respuesta;
        }
    }
}