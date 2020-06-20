using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FermeWeb1._0.Models
{
    public class Direccion
    {
        public int id { get; set; }
        public int region { get; set; }
        public string comuna { get; set; }
        public string pasaje { get; set; }
        public int numero { get; set; }
        public string numeroDepto { get; set; }

        public Direccion()
        {

        }

        public void Init()
        {
            this.id = 0;
            this.region = 0;
            this.comuna = "";
            this.pasaje = "";
            this.numero = 0;
            this.numeroDepto = "";
        }

        public void direccion(int id, int region, string comuna, string pasaje, int numero, string numeroDepto)
        {
            this.id = id;
            this.region = region;
            this.comuna = comuna;
            this.pasaje = pasaje;
            this.numero = numero;
            this.numeroDepto = numeroDepto;
        }
    }
}