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

        public FileResult Index()
        {
            var ruta = Server.MapPath("HSDC15_-_5_User_Experience.pdf");
            return File(ruta, "application/pdf", "User_Experience.pdf");
            //return View();
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