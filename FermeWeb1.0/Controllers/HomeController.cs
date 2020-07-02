using FermeWeb1._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FermeWeb1._0.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(Cliente objeto)
        {
            string nombre = "null";
            if (objeto.correoCli!="")
            {
                nombre = objeto.nombre.ToString();
                
            }
            System.Web.HttpContext.Current.Session["data"] = nombre;
            List<Producto> produ = new ProductoController().productos();
            ViewData["ProductosData"] = produ;
            return View("Producto");
        }
        public ActionResult Error()
        {
            return View("Error");
        }
    }
}