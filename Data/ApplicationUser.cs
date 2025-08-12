using Connect4.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Connect4.Data
{
    [Index(nameof(Identificacion), IsUnique = true)]
    public class ApplicationUser : IdentityUser
    {
        public int Identificacion { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? FotoBase64 { get; set; }
        public Marcador? Marcador { get; set; }
    }
}


