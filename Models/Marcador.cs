using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Connect4.Models
{
    public class Marcador
    {
        [Key]
        public int Id { get; set; }
        public int Puntuacion { get; set; } = 0;
        public int Ganadas { get; set; } = 0;
        public int Perdidas { get; set; } = 0;
        public int Empatadas { get; set; } = 0;

        [Required]
        public string? ApplicationUserId { get; set; }

        [ForeignKey("ApplicationUserId")]
        public Connect4.Data.ApplicationUser? ApplicationUser { get; set; }
    }
}

