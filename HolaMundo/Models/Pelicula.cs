using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HolaMundo.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        public bool EstaEncartelera { get; set; }
        [StringLength(120)]
        public string Genero { get; set; }
    }
} 