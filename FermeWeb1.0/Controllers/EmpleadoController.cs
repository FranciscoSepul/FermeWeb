using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FermeWeb1._0.Models;
using System.Configuration;


namespace FermeWeb1._0.Controllers
{
    public class EmpleadoController : Controller
    {
        //Declarar
        string tokenEmpleado = ConfigurationManager.AppSettings["tokenF"].ToString();
        List<Empleado> empleadoList = new List<Empleado>();
        Empleado empleado = new Empleado();

        //Deserializar
        public List<Empleado> empleados()
        {
            string url = "empleado/todos/" + tokenEmpleado;
            string resultado = new HerramientasController().calling(url);
            empleadoList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Empleado>>(resultado);
            return empleadoList;
        }

        //Buscar por el RUN
        public Empleado buscarRun()
        {
            string run = "19557236";
            string url = "/empleado/buscar/" + run + "/" + tokenEmpleado;
            string resultado = new HerramientasController().calling(url);
            empleado = Newtonsoft.Json.JsonConvert.DeserializeObject<Empleado>(resultado);
            return empleado;
        }
    }
}