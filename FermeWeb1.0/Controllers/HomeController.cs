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
        public ActionResult Index(Cliente cliente)
        {
            return View("Producto",cliente);
        }
        public ActionResult Error()
        {
            return View("Error");
        }
    }
}