using HolaMundo.DAL;
using HolaMundo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HolaMundo.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            var persona = new Persona()
            {
                Nombre = "Ayanami",
                Edad = 13,
                Empleado = true,
                Nacimiento = new DateTime(2018,1,6)
            };
            ViewBag.Propiedad = persona;
             return View();
        }

        public ActionResult About()
        {
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