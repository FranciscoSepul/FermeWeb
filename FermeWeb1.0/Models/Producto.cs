using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FermeWeb1._0.Models
{
    public class Producto
    {
        public int id { get; set; }
        public int idTipoProducto { get; set; }
        public int idSucursal { get; set; }
        public int idProveedor { get; set; }
        public string nombre { get; set; }
        public int stock { get; set; }
        public int preciouni { get; set; }
        public string rutadoc { get; set; }
        public int cantidad { get; set; }

        public Producto()
        {

        }

        public void Init()
        {
            this.id = 0;
            this.idTipoProducto = 0;
            this.idSucursal = 0;
            this.idProveedor = 0;
            this.nombre = "";
            this.stock = 0;
            this.preciouni = 0;
            this.rutadoc = "";
            this.cantidad = 0;
        }

        public void producto(int id, int idTipoProducto, int idSucursal, int idProveedor, string nombre, int stock, int preciouni, string rutadoc,int cantidad)
        {
            this.id = id;
            this.idTipoProducto = idTipoProducto;
            this.idSucursal = idSucursal;
            this.idProveedor = idProveedor;
            this.nombre = nombre;
            this.stock = stock;
            this.preciouni = preciouni;
            this.rutadoc = rutadoc;
            this.cantidad = cantidad;
        }
    }
}