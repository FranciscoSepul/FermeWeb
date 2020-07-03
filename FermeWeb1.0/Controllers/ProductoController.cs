using FermeWeb1._0.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace FermeWeb1._0.Controllers
{
    public class ProductoController : Controller
    {
        //Declarar
        string tokenProducto = ConfigurationManager.AppSettings["tokenF"].ToString();
        List<Producto> productoList = new List<Producto>();
        Producto producto = new Producto();
        
        public List<Producto> productos()
        {

            string url = "/Producto/todos/" + tokenProducto;
            string resultado = new HerramientasController().calling(url);
            productoList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Producto>>(resultado); 
            return productoList;
        }

        //Buscar prod. por nombre
        public Producto buscarNombre()
        {
            string nombre = "Martillo";
            string url = "/Empleado/buscar/" + nombre + "/" + tokenProducto;
            string resultado = new HerramientasController().calling(url);
            producto = Newtonsoft.Json.JsonConvert.DeserializeObject<Producto>(resultado);
            return producto;
        }
        [HttpPost]
        public string compras(Producto producto)
        {
            if (producto!=null)
            {
                List<Producto> lista = new List<Producto>();
                lista.Add(producto);
            }
            string respuesta = "";

            return respuesta;
           
        }


    }
}