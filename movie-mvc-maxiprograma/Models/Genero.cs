using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace mvc_movie_maxiprograma.Models
{
    public class Genero
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        public List<Pelicula>? PeliculasGenero { get; set; }
    }
}
