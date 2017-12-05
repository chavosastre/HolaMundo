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

            //var peliculasService = new PeliculasService();
            //var model = peliculasService.ObtenerPeliculas();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            //ViewBag.UnInt = 45;
            //ViewBag.UnaFecha = new DateTime(1800,4,7);
            //ViewData["MiMensaje"] = "Esto fué creado con ViewData";

            return View();
        }

        public ActionResult MiAction()
        {
            return View();
        }
    }
}