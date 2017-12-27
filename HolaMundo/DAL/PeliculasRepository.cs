using HolaMundo.Models;
using System.Collections.Generic;

namespace HolaMundo.DAL
{
    public class PeliculasRepository
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>()
            {
                new Pelicula
                {
                    Titulo = "Pete's Dragon",
                    EstaEncartelera = true,
                    Genero = "Fantasía"
                },
                new Pelicula
                {
                    Titulo = "<b>Mechanic: Resurrection<b><script>alert('hakeado')</script>",
                    EstaEncartelera = true,
                    Genero = "Acción"
                },
                new Pelicula
                {
                    Titulo = "Deadpool",
                    EstaEncartelera = false,
                    Genero = "Acción"
                }
            };
        }
    }
}