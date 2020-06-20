using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FermeWeb1._0.Models
{
    public class Documento
    {
        public int id { get; set; }
        public int tipoDoc { get; set; }
        public int NumFolio { get; set; }
        public string fecha { get; set; }
        public string rutadoc { get; set; }

        public Documento()
        {

        }

        public void Init()
        {
            this.id = 0;
            this.tipoDoc = 0;
            this.NumFolio = 0;
            this.fecha = "";
            this.rutadoc = "";
        }

        public void documento(int id, int tipoDoc, int NumFolio, string fecha, string rutadoc)
        {
            this.id = id;
            this.tipoDoc = tipoDoc;
            this.NumFolio = NumFolio;
            this.fecha = fecha;
            this.rutadoc = rutadoc;
        }
    }
}