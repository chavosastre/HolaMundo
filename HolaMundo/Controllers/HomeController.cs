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
        private PeliculasRepository _peliculasRepository;

        public HomeController()
        {
            _peliculasRepository = new PeliculasRepository();
        }

        public ActionResult Index()
        {
             return View();
        }

        public ActionResult About(int edad)
        {
            ViewBag.Message = "Tu edad es " + edad.ToString();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            var model = _peliculasRepository.ObtenerPeliculas();
            return View(model);
        }

        public ActionResult Grafica()
        {
            return View();
        }
    }
}