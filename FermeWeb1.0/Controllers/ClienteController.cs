using FermeWeb1._0.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;

namespace FermeWeb1._0.Controllers
{
    public class ClienteController : Controller
    {
        string tokenl = ConfigurationManager.AppSettings["tokenF"].ToString();
        List<Cliente> resultados = new List<Cliente>();
        Cliente resultado = new Cliente();

        public ActionResult index()
        {
            return View("LogIn");
        }

        public List<Cliente> clientes()
        {
            string url = "/clientes/todos/" + tokenl;
            string resul = new HerramientasController().calling(url);
            resultados = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Cliente>>(resul);
            return resultados;
        }
        public Cliente buscarRut(string run)
        {
           
            string url = "/clientes/buscar/" + run + "/" + tokenl;
            string resul = new HerramientasController().calling(url);
            resultado = Newtonsoft.Json.JsonConvert.DeserializeObject<Cliente>(resul);
            return resultado;
        }

        //[HttpPost]
        public ActionResult LogIn(string correo, string pass)
        {
            
            string url = "/clientes/login/" + correo + "/" + pass + "/" + tokenl;
            string resul = new HerramientasController().calling(url);
            resultado = Newtonsoft.Json.JsonConvert.DeserializeObject<Cliente>(resul);            
            return View("LogIn");
        }
        public ActionResult Registrar()
        {
            string co = "Juan@gmail.com";
            string pass = "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918";
            string url = "/clientes/login/" + co + "/" + pass + "/" + tokenl;
            string resul = new HerramientasController().calling(url);
            resultado = Newtonsoft.Json.JsonConvert.DeserializeObject<Cliente>(resul);
            return View("Registrar");
        }
        public ActionResult enviarClave(string runCli,string correo)
        {
            Cliente cli = buscarRut(runCli);
            string asunto = "Recuperacion de Password";
            Boolean desc=true;
            int cambio = 1;
            if (cli.correoCli!=correo)
            {
                desc = false;
            }
            else
            {
                string pass = cli.nombre.Substring(0, 3)+cli.apellido.Substring(1, 2)+cli.runCliente.Substring(3, 4);
                string url = "/clientes/CambiarPass/" + runCli + "/" + pass + "/" + cambio + "/" + tokenl;
                string cuerpo =new HerramientasController().correoPass(pass,correo);
                string resul = new HerramientasController().calling(url);
                if(resul!= "Exito")
                {
                    desc = false;
                }
                else
                {
                    var resultadosmtp = new HerramientasController().Smtp(correo, asunto, cuerpo);
                    desc = true;
                }
                
            }                    
            
            return View("Registrar",desc);
        }
        public ActionResult Recuperar()
        {
            return View("Recuperar");
        }

    }
}

