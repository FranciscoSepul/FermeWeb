using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FermeWeb1._0.Models
{
    public class Empresa
    {
        public int id { get; set; }
        string rutEmpresa { get; set; }
        string dvrut { get; set; }
        string nombteEmpresa { get; set; }
        string correoEmp { get; set; }
        string numerotel { get; set; }

        public Empresa()
        {

        }

        public void Init()
        {
            this.id = 0;
            this.rutEmpresa = "";
            this.dvrut = "";
            this.nombteEmpresa = "";
            this.correoEmp = "";
            this.numerotel = "";
        }

        public void empresa(int id, string rutEmpresa, string dvrut, string nombteEmpresa, string correoEmp, string numerotel)
        {
            this.id = id;
            this.rutEmpresa = rutEmpresa;
            this.dvrut = dvrut;
            this.nombteEmpresa = nombteEmpresa;
            this.correoEmp = correoEmp;
            this.numerotel = numerotel;
        }
    }
}