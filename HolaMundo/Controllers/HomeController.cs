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

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            var model = _peliculasRepository.ObtenerPeliculas();
            return View(model);
        }
    }
}