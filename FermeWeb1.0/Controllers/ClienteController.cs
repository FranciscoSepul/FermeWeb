using FermeWeb1._0.Models;
using System;
using System.Net;
using System.Text;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace FermeWeb1._0.Controllers
{
    public class ClienteController : Controller
    {
        public string clientes()
        {
            string apiUrl = "http://localhost:8091/Empleado/buscar";
            string rut = "19557236";
            var input = new
            {
                runEmpleado = rut,
            };
            string inputJson = (new JavaScriptSerializer()).Serialize(input);
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl + "/GetCustomers", inputJson);
            Cliente customers = (new JavaScriptSerializer()).Deserialize<Cliente>(json);
            Console.WriteLine(customers.id);
            string id =Convert.ToString( customers.id);
            return "hola we"+id;
        }
    }
}