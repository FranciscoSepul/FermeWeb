using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FermeWeb1._0.Models
{
    public class Proveedor
    {
        public int id { get; set; }
        public int idEmpresa { get; set; }
        public string runProveedor { get; set; }
        public string digitoVerif { get; set; }
        public int estado { get; set; }
        public string nombre { get; set; }
        public string numerotel { get; set; }
        public string direccion { get; set; }
        public string correoProv { get; set; }


        public Proveedor()
        {

        }

        public void Init()
        {
            this.id = 0;
            this.idEmpresa = 0;
            this.runProveedor = "";
            this.digitoVerif = "";
            this.estado = 0;
            this.nombre = "";
            this.numerotel = "";
            this.direccion = "";
            this.correoProv = "";
            
        }

        public void proveedor(int id, int idEmpresa, string runProveedor, string digitoVerif, int estado, string nombre, string numerotel, string direccion, string correoProv)
        {
            this.id = id;
            this.idEmpresa = idEmpresa;
            this.runProveedor = runProveedor;
            this.digitoVerif = digitoVerif;
            this.estado = estado;
            this.nombre = nombre;
            this.numerotel = numerotel;
            this.direccion = direccion;
            this.correoProv = correoProv;
        }
    }
}