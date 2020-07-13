using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FermeWeb1._0.Models;
using System.Configuration;
using System.Web.Mvc;

namespace FermeWeb1._0.Controllers
{
    public class VentasController : Controller
    {
        string tokenl = ConfigurationManager.AppSettings["tokenF"].ToString();

        public string crear(string mailClie, int idProd, int cantidad, int total, int tipoDoc, string ruta, int idretiro)
        {
            
            string url = "/Ventas/realizarv/" + mailClie + "/" + idProd + "/" + cantidad + "/" + total + "/"+ruta+ "/" + tipoDoc + "/" + idretiro + "/" + tokenl;
            string resul = new HerramientasController().calling(url);
            return resul;
        }
    }
}