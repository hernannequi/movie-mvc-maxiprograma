namespace mvc_movie_maxiprograma.Models
{
    public class Usuario
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string ImagenUrlPerfil { get; set; }

        public List<Favorito>? ListaPeliculasFavoritas { get; set; }

    }
}
