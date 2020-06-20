using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FermeWeb1._0.Models
{
    public class Empleado
    {
        public int id { get; set; }
        public int idcargo { get; set; }
        public int iddireccion { get; set; }
        public int idsucursal { get; set; }
        public int estado { get; set; }
        public string runEmpleado { get; set; }
        public int sexoE { get; set; }
        public string digitoVerif { get; set; }
        public string nombree { get; set; }
        public string apellido { get; set; }
        public string correoEmple { get; set; }
        public string contrasena { get; set; }

        public Empleado()
        {

        }

        public void Init()
        {
            this.id = 0;
            this.idcargo = 0;
            this.iddireccion = 0;
            this.idsucursal = 0;
            this.estado = 0;
            this.runEmpleado = "";
            this.sexoE = 0;
            this.digitoVerif = "";
            this.nombree = "";
            this.apellido = "";
            this.correoEmple = "";
            this.contrasena = "";
        }

        public void empleado(int id, int idcargo, int iddireccion, int estado, string runEmpleado, int sexoE, string digitoVerif, string nombree, string apellido, string correoEmple, string contrasena)
        {
            this.id = id;
            this.idcargo = idcargo;
            this.iddireccion = iddireccion;
            this.estado = estado;
            this.runEmpleado = runEmpleado;
            this.sexoE = sexoE;
            this.digitoVerif = digitoVerif;
            this.nombree = nombree;
            this.apellido = apellido;
            this.correoEmple = correoEmple;
            this.contrasena = contrasena;
        }
    }
}