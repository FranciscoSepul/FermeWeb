using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FermeWeb1._0.Models;
using System.Configuration;

namespace FermeWeb1._0.Controllers
{
    public class DetalleVentaController : Controller
    {
        //Declarar
        string tokenDVenta = ConfigurationManager.AppSettings["tokenF"].ToString();
        List<DetalleVenta> detVentaList = new List<DetalleVenta>();
        DetalleVenta detVenta = new DetalleVenta();

        //Deserializar
        public List<DetalleVenta> detalleVentas()
        {
            string url = "/detalleVenta/todos/" + tokenDVenta;
            string resultado = new HerramientasController().calling(url);
            detVentaList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DetalleVenta>>(resultado);
            return detVentaList;
        }


    }
}