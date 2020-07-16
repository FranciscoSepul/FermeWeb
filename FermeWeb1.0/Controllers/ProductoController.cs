using FermeWeb1._0.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.collection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.Services.Description;
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

        public ActionResult Herramientas()
        {
            return View();
        }
        public ActionResult Decoracion()
        {
            return View();
        }
        public ActionResult Muebles()
        {
            return View();
        }
        public ActionResult AireLibre()
        {
            return View();
        }
        public ActionResult VentaRealizadas()
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
                int total = lista[i].preciouni * cantidad;
                int tipoDoc = 1;
                string ruta = "F";
                int idretiro = 1;

                string result = new VentasController().crear(mail, idProd, cantidad, total, tipoDoc, ruta, idretiro);
                if (result != "Exito")
                {

                }   
            }
            return View();
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
            if (System.Web.HttpContext.Current.Session["ListaProd"] == null)
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
        public ActionResult Boleta()
        {
            return View("Boleta");
        }

        public ActionResult PdfCompra()
        {

            List<Producto> lista = JsonConvert.DeserializeObject<List<Producto>>(getSession());

            //FileStream fs = new FileStream("c://pdf/reporte.pdf", FileMode.Create);
            MemoryStream ms = new MemoryStream();
            ms.WriteTo(Response.OutputStream);
            Document documento = new Document(iTextSharp.text.PageSize.LETTER,30f,20f,50f,40f);
            PdfWriter pw = PdfWriter.GetInstance(documento,ms);
            string pathImage = Server.MapPath("/Imagenes/FERME Logo.png");
            pw.PageEvent = new HeaderFotter(pathImage);
            documento.Open();
            
            PdfPTable table = new PdfPTable(4);
            int calculo = 0;
            int suma = 0;
            documento.Add( Chunk.NEWLINE );

            documento.Add(new Paragraph("Gracias por por preferir Ferreterias ferme a continuacion se detallaran los productos comprados en nuestra tienda web "));

            documento.Add(Chunk.NEWLINE);
            PdfPCell _cell = new PdfPCell();
            _cell = new PdfPCell(new Paragraph("Nombre"));
            _cell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(_cell);
            _cell = new PdfPCell(new Paragraph("Cantidad"));
            _cell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(_cell);
            _cell = new PdfPCell(new Paragraph("Precio Unitario"));
            _cell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(_cell);
            _cell = new PdfPCell(new Paragraph("Monto"));
            _cell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(_cell);

            foreach (var item in lista)
            {
                
                calculo = item.preciouni * item.cantidad;
                suma += calculo;
                _cell = new PdfPCell(new Paragraph(item.nombre));
                _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(_cell);
                _cell = new PdfPCell(new Paragraph(item.cantidad.ToString()));
                _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(_cell);
                _cell = new PdfPCell(new Paragraph(item.preciouni.ToString()));
                _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(_cell);
                _cell = new PdfPCell(new Paragraph(calculo.ToString()));
                _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(_cell);
            }
            documento.Add(Chunk.NEWLINE);
            PdfPCell _celldas = new PdfPCell();
            _celldas = new PdfPCell(new Paragraph(""));
            _celldas.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(_celldas);
            _celldas = new PdfPCell(new Paragraph(""));
            _celldas.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(_celldas);
            _celldas = new PdfPCell(new Paragraph("Total:"));
            _celldas.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(_celldas);
            _celldas = new PdfPCell(new Paragraph(suma.ToString()));
            _celldas.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(_celldas);
            documento.Add(table);
            documento.Close();

            byte[] byteStream = ms.ToArray();
            ms = new MemoryStream();
            ms.Write(byteStream, 0, byteStream.Length);
            ms.Position = 0;


            return new FileStreamResult(ms, "application/pdf");

        }
        class HeaderFotter : PdfPageEventHelper
        {
            string phatIma = null;
            public HeaderFotter(string logo)
            {
                phatIma = logo;
            }
            public override void OnEndPage(PdfWriter writer, Document document)
            {
                //base.OnEndPage(writer, document);
                PdfPTable tbHead = new PdfPTable(3);
                tbHead.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                tbHead.DefaultCell.Border = 0;

                tbHead.AddCell(new Paragraph());
                document.Add(Chunk.NEWLINE);
                PdfPCell _cell = new PdfPCell(new Paragraph("Boleta Electronica"));
                _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                tbHead.AddCell(_cell);
                tbHead.AddCell(new Paragraph());

                tbHead.WriteSelectedRows(0, -1, document.LeftMargin, writer.PageSize.GetTop(document.TopMargin)+40, writer.DirectContent);

                PdfPTable tbfooter = new PdfPTable(3);
                tbfooter.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                tbfooter.DefaultCell.Border = 0;

                tbfooter.AddCell(new Paragraph());
                PdfPCell _celle = new PdfPCell(new Paragraph("Ferreteria Ferme Siempre con los chilenos"));
                _celle.HorizontalAlignment = Element.ALIGN_CENTER;
                tbfooter.AddCell(_celle);
                tbfooter.AddCell(new Paragraph());
                tbfooter.WriteSelectedRows(0, -1, document.LeftMargin, writer.PageSize.GetBottom(document.BottomMargin) -5, writer.DirectContent);



                Image logo = Image.GetInstance(phatIma);
                logo.SetAbsolutePosition(document.LeftMargin,writer.PageSize.GetTop(document.TopMargin)+1);
                logo.ScaleAbsolute(50f, 50f);
                document.Add(logo);

            }
        }
    }
}