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
             return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            var peliculasService = new PeliculasService();
            var model = peliculasService.ObtenerPeliculas();

            return View(model);
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(int edad)
        {
            ViewBag.Message = "Your contact page." + edad;

            return View();
        }
    }
}