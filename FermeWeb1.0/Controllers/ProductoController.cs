using FermeWeb1._0.Models;
using Newtonsoft.Json;
using Rotativa;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
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
        public ActionResult carro()
        {
            return View();
        }
        public ActionResult RealizarCompra()
        {
            var mail = Session["data"].ToString();
            List<Producto> lista = JsonConvert.DeserializeObject<List<Producto>>(getSession());
            for (int i = 0; i < lista.Count; i++)
            {
                int idProd = lista[i].id;
                int cantidad = lista[i].cantidad;
                int total = lista[i].preciouni*cantidad;
                int tipoDoc = 1;
                string ruta = "F";
                int idretiro = 1;
                string result = new VentasController().crear(mail,idProd,cantidad,total,tipoDoc,ruta,idretiro);
                if (result!= "Exito")
                {

                }
                string pdf = new HerramientasController().PdfCompra();
                string smtp = new HerramientasController().Smtp(mail,"Boleta compra Ferme",pdf);
                if (smtp!= "exito")
                {

                }                    
            }
            return View("VentaRealizada");
        }
        [HttpGet]
        public string llenar()
        {
            var session = getSession();
            return session;
        }
        public string setSessiones(object objeto)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            return (System.Web.HttpContext.Current.Session["ListaProd"] = jss.Serialize(objeto)).ToString();
        }
        public string getSession()
        {
            string resp;
            if (System.Web.HttpContext.Current.Session["ListaProd"]==null)
            {
                resp = null;
            }
            else
            {
                resp = System.Web.HttpContext.Current.Session["ListaProd"].ToString();
            }
            return resp;
           
        }

        [HttpPost]
        public string compras(Producto prod)
        {
            if (getSession() == null)
            {
                List<Producto> lista = new List<Producto>();
                lista.Add(prod);
                setSessiones(lista);
            }
            else
            {
                List<Producto> lista = JsonConvert.DeserializeObject<List<Producto>>(getSession());
                lista.Add(prod);
                setSessiones(lista);
            }
            var value = getSession(); 
            return value;
        }


        public ActionResult Imprimir()
        {
            return new ActionAsPdf("carro") { FileName = "Prueba.pdf" };
        }

    }
}