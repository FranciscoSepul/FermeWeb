using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FermeWeb1._0.Models
{
    public class Sucursal
    {
        public int id { get; set; }
        public int iddireccion { get; set; }
        public string nombres { get; set; }
        public string telefono { get; set; }

        public Sucursal()
        {

        }

        public void Init()
        {
            this.id = 0;
            this.iddireccion = 0;
            this.nombres = "";
            this.telefono = "";
        }

        public void sucursal(int id, int iddireccion, string nombres, string telefono)
        {
            this.id = id;
            this.iddireccion = iddireccion;
            this.nombres = nombres;
            this.telefono = telefono;
        }
    }
}