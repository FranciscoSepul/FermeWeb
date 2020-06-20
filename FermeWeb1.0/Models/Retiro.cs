using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FermeWeb1._0.Models
{
    public class Retiro
    {
        public int idretiro { get; set; }
        public string nombreRetiro { get; set; }

        public Retiro()
        {

        }

        public void Init()
        {
            this.idretiro = 0;
            this.nombreRetiro = "";
        }

        public void retiro(int idretiro, string nombreRetiro)
        {
            this.idretiro = idretiro;
            this.nombreRetiro = nombreRetiro;
        }
    }
}