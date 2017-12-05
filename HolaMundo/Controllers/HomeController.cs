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

        //Ejemplo para mandar un json
        //public class Persona
        //{
        //    public string Nombre { get; set; }
        //    public int Edad { get; set; }
        //}

        public ActionResult Index()
        {
            //Ejemplo para mandar un json
            //var persona1 = new Persona()
            //{
            //    Nombre = "Salvador",
            //    Edad = 40
            //};
            //var persona2 = new Persona()
            //{
            //    Nombre = "Edgar",
            //    Edad = 47
            //};

            //return Json(new List<Persona>(){ persona1, persona2}, JsonRequestBehavior.AllowGet);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            var peliculasService = new PeliculasService();
            var model = peliculasService.ObtenerPeliculas();

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}