using FermeWeb1._0.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace FermeWeb1._0.Controllers
{
    public class ClienteController : Controller
    {
        string tokenl = "F3rm3P0rt4";
        public List<Cliente> cliente()
        {
            List<Cliente> cli = new List<Cliente>();
            string apiUrl = "http://localhost:8091/clientes/todos";
            var tablaAux = new
            {
                token = tokenl,
            };
            string inputJson = (new JavaScriptSerializer()).Serialize(tablaAux);
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json =client.UploadString(apiUrl + "/GetCustomers", inputJson);
            cli = (new JavaScriptSerializer()).Deserialize<List<Cliente>>(json);
            return cli;
        }
        public string clientes()
        {
            string apiUrl = "http://ec2-18-217-117-248.us-east-2.compute.amazonaws.com:8080/Empleado/buscar";
            string rut = "19557236";
            var tablaAux = new
            {
                runEmpleado = rut,
                //token = tokenl,
            };
            string inputJson = (new JavaScriptSerializer()).Serialize(tablaAux);
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl + "/GetCustomers", inputJson);
            Cliente customers = json;
            string cli = customers.apellido;
            return cli;
        }
    }
}