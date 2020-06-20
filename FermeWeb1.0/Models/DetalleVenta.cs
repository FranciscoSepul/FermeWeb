using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FermeWeb1._0.Models
{
    public class DetalleVenta
    {
        public int idDetalle { get; set; }
        public int idProducto { get; set; }
        public string fechaCompra { get; set; }
        public int cantidad { get; set; }
        public int total { get; set; }

        public DetalleVenta()
        {

        }

        public void Init()
        {
            this.idDetalle = 0;
            this.idProducto = 0;
            this.fechaCompra = "";
            this.cantidad = 0;
            this.total = 0;
        }

        public void detalleventa(int idDetalle, int idProducto, string fechaCompra, int cantidad, int total)
        {
            this.idDetalle = idDetalle;
            this.idProducto = idProducto;
            this.fechaCompra = fechaCompra;
            this.cantidad = cantidad;
            this.total = total;
        }

    }
}