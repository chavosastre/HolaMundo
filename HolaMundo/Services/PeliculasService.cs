using HolaMundo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolaMundo.Services
{
    public class PeliculasService
    {
        public Pelicula ObtenerPelicula()
        {
            return new Pelicula()
            {
                Titulo = "Escape Plan",
                Duracion = 115,
                Pais = "USA",
                Publicacion = new DateTime(2013,12,5)
            };
        }

        public List<Pelicula> ObtenerPeliculas()
        {
            var pelicula1 = new Pelicula()
            {
                Titulo = "Escape Plan",
                Duracion = 115,
                Pais = "USA",
                Publicacion = new DateTime(2013, 12, 5)
            };

            var pelicula2 = new Pelicula()
            {
                Titulo = "Capitan América Civil War",
                Duracion = 147,
                Pais = "USA",
                Publicacion = new DateTime(2016, 04, 29)
            };

            return new List<Pelicula> { pelicula1, pelicula2 };
        }
    }
}