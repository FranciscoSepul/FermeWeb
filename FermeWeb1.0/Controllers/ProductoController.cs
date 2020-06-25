using FermeWeb1._0.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FermeWeb1._0.Controllers
{
    public class ProductoController : Controller
    {
        //Declarar
        string tokenProducto = ConfigurationManager.AppSettings["tokenF"].ToString();
        List<Producto> productoList = new List<Producto>();
        Producto producto = new Producto();

        //Deserializar
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
    }
}