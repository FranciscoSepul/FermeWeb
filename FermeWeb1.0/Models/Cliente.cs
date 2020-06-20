using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FermeWeb1._0.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public int idDireccion { get; set; }
        public string runCliente { get; set; }
        public string digitoVerif { get; set; }
        public int estado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int sexo { get; set; }
        public string correoCli { get; set; }
        public string contrasena { get; set; }

        public Cliente()
        {
            Init();
        }

        public void Init()
        {
            this.id = 0;
            this.idDireccion = 0;
            this.runCliente = "";
            this.digitoVerif = "";
            this.estado = 0;
            this.nombre = "";
            this.apellido = "";
            this.sexo = 0;
            this.correoCli = "";
            this.contrasena = "";
        }
        public void cliente(int id, int idDireccion, string runCliente, string digitoVerif, int estado, string nombre, string apellido, int sexo, string correoCli, string contrasena)
        {
            this.id = id;
            this.idDireccion = idDireccion;
            this.runCliente = runCliente;
            this.digitoVerif = digitoVerif;
            this.estado = estado;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sexo = sexo;
            this.correoCli = correoCli;
            this.contrasena = contrasena;

        }

    }
}