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

        public Boolean crear(string mailClie, int idDetalle, int idDoc, int idRetiro, int idEmp, int idFormaPago)
        {
            string url = "/Ventas/crear/" + mailClie + "/" + idDetalle + "/" + idDoc + "/" + idRetiro + "/" + idEmp + "/" + idFormaPago + "/" + tokenl;
            string resul = new HerramientasController().calling(url);
            return true;
        }
    }
}