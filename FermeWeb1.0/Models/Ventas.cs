using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FermeWeb1._0.Models
{
    public class Ventas
    {
        public int id { get; set; }
        public int idCliente { get; set; }
        public int iddetalle { get; set; }
        public int idDoc { get; set; }
        public int idretiro { get; set; }
        public int idEmpleado { get; set; }
        public int idFormaPago { get; set; }
        public int Estado { get; set; }

        public Ventas()
        {

        }

        public void Init()
        {
            this.id = 0;
            this.idCliente = 0;
            this.iddetalle = 0;
            this.idDoc = 0;
            this.idretiro = 0;
            this.idEmpleado = 0;
            this.idFormaPago = 0;
            this.Estado = 0;
        }

        public void ventas(int id, int idCliente, int iddetalle, int idDoc, int idretiro, int idEmpleado, int idFormaPago, int Estado)
        {
            this.id = id;
            this.idCliente = idCliente;
            this.iddetalle = iddetalle;
            this.idDoc = idDoc;
            this.idretiro = idretiro;
            this.idEmpleado = idEmpleado;
            this.idFormaPago = idFormaPago;
            this.Estado = Estado;
        }
    }
}