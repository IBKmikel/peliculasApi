using System.ComponentModel.DataAnnotations;

namespace PeliculasAPI.DTOs
{
    public class RatingDTO
    {
        public int peliculaId { get; set; }
        [Range(1,5)]
        public int Puntuacion { get; set; }
    }
}
