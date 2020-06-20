using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FermeWeb1._0.Models
{
    public class FormaDePago
    {
        public int id { get; set; }
        public int efectivo { get; set; }
        public int debito { get; set; }
        public int tarjeta { get; set; }
        public int pOnline { get; set; }

        public FormaDePago()
        {

        }

        public void Init()
        {
            this.id = 0;
            this.efectivo = 0;
            this.debito = 0;
            this.tarjeta = 0;
            this.pOnline = 0;
        }

        public void formadepago(int id, int efectivo, int debito, int tarjeta, int pOnline)
        {
            this.id = id;
            this.efectivo = efectivo;
            this.debito = debito;
            this.tarjeta = tarjeta;
            this.pOnline = pOnline;
        }
    }
}