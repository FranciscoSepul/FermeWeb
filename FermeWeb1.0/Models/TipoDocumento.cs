using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FermeWeb1._0.Models
{
    public class TipoDocumento
    {
        public int id { get; set; }
        public string Nombre { get; set; }

        public TipoDocumento()
        {

        }

        public void Init()
        {
            this.id = 0;
            this.Nombre = "";
        }

        public void tipodocumento(int id, string Nombre)
        {
            this.id = id;
            this.Nombre = Nombre;
        }
    }
}