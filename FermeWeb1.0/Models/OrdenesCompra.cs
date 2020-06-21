using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FermeWeb1._0.Models
{
    public class OrdenesCompra
    {
        public int id { get; set; }
        public int idSuc { get; set; }
        public int idProveedor { get; set; }
        public string fecha { get; set; }
        public int cantidad { get; set; }

        public OrdenesCompra()
        {

        }

        public void Init()
        {
            this.id = 0;
            this.idSuc = 0;
            this.idProveedor = 0;
            this.fecha = "";
            this.cantidad = 0;
        }

        public void ordenescompra(int id, int idSuc, int idProveedor, string fecha, int cantidad)
        {
            this.id = id;
            this.idSuc = idSuc;
            this.idProveedor = idProveedor;
            this.fecha = fecha;
            this.cantidad = cantidad;
        }
    }
}