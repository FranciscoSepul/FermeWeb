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
        public ActionResult Index()
        {
            dynamic model = new System.Dynamic.ExpandoObject();
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