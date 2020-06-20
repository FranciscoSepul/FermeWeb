using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FermeWeb1._0.Models
{
    public class TipoProducto
    {
        public int id { get; set; }
        public string nombreTipoProducto { get; set; }

        public TipoProducto()
        {

        }

        public void Init()
        {
            this.id = 0;
            this.nombreTipoProducto = "";
        }

        public void tipoproducto(int id, string nombreTipoProducto)
        {
            this.id = id;
            this.nombreTipoProducto = nombreTipoProducto;
        }
    }
}