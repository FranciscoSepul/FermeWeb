using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace FermeWeb1._0.Models
{
    public class Perfil
    {
        public int id { get; set; }
        public string nombreCargo { get; set; }

        public Perfil()
        {

        }

        public void Init()
        {
            this.id = 0;
            this.nombreCargo = "";
        }

        public void perfil(int id, string nombreCargo)
        {
            this.id = id;
            this.nombreCargo = nombreCargo;
        }
    }
}