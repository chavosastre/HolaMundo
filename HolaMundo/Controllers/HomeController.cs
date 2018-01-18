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

            ViewBag.Milistado = ObtenerListado(); ;
            return View();
        }

        public List<SelectListItem> ObtenerListado()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Text = "Sí",
                    Value = "1"
                },
                new SelectListItem()
                {
                    Text = "No",
                    Value = "2"
                },
                new SelectListItem()
                {
                    Text="Tal véz",
                    Value = "3"
                }
            };
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