using HolaMundo.DAL;
using HolaMundo.Models;
using HolaMundo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace HolaMundo.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            var personas = new List<Persona>()
            {
                new Persona()
                {
                    Nombre = "Juan",
                    Edad=10
                },
                new Persona()
                {
                    Nombre="Pedro",
                    Edad=11
                }
            };
            ViewBag.MiListado = personas;
            return View();
        }


        public ActionResult About()
        {
            var personas = new List<Persona>()
            {
                new Persona()
                {
                    Nombre = "Juan2",
                    Edad=10
                },
                new Persona()
                {
                    Nombre="Pedro2",
                    Edad=11
                }
            };
            ViewBag.MiListado = personas;
            ViewBag.Message = "Página acerca de";

            return View();
        }

        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            
            return View();
        }

        public ActionResult Grafica()
        {
            return View();
        }
    }

    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool Empleado { get; set; }
        public DateTime Nacimiento { get; set; }
    }
}