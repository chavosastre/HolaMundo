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

            ViewBag.Milistado = ObtenerListado();
            ViewBag.MiListadoEnum = ToListSelectListItem<ResultadoOperacion>();
            return View();
        }
         
        public List<SelectListItem> ToListSelectListItem<T>()
        {
            var t = typeof(T); 

            if (!t.IsEnum)
            {
                throw new ApplicationException("Tipo debe ser enum");
            }

            var members = t.GetFields(BindingFlags.Public | BindingFlags.Static);
            var result = new List<SelectListItem>();
            foreach (var member in members)
            {
                var attributeDescription = member.GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
                var description = member.Name;

                if (attributeDescription.Any())
                {
                    description = ((System.ComponentModel.DescriptionAttribute)attributeDescription[0]).Description;
                }

                var valor = ((int)Enum.Parse(t, member.Name));
                result.Add(new SelectListItem()
                {
                    Text = description,
                    Value = valor.ToString()
                });
            }
            return result;
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