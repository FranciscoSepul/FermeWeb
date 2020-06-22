using FermeWeb1._0.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;

namespace FermeWeb1._0.Controllers
{
    public class ClienteController : Controller
    {
        string tokenl = ConfigurationManager.AppSettings["tokenF"].ToString();
        List<Cliente> resultados = new List<Cliente>();
        Cliente resultado = new Cliente();
        public List<Cliente> clientes()
        {            
            string url = "/clientes/todos/" + tokenl;
            string resul = new HerramientasController().calling(url);
            resultados = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Cliente>>(resul);
            return resultados;
        }
        public Cliente buscarRut()
        {
            string run = "12423531";
            string url = "/clientes/buscar/"+run+"/"+ tokenl;
            string resul = new HerramientasController().calling(url);
            resultado = Newtonsoft.Json.JsonConvert.DeserializeObject<Cliente>(resul);
            return resultado;
        }
        public Cliente logIn()
        {
            string url = "/clientes//" + tokenl;
            string resul = new HerramientasController().calling(url);
            resultado = Newtonsoft.Json.JsonConvert.DeserializeObject<Cliente>(resul);
            return resultado;
        }
    }
}

