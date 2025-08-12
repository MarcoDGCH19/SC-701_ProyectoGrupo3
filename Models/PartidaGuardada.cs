using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Connect4.Data;

public enum EstadoPartida
{
    Pendiente,
    Finalizada
}

public class PartidaGuardada
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Jugador1 { get; set; } = string.Empty;

    [Required]
    public string Jugador2 { get; set; } = string.Empty;

    [Required]
    public DateTime FechaCreacion { get; set; }

    public DateTime? FechaFinalizacion { get; set; }

    [Required]
    public EstadoPartida Estado { get; set; }

    [Required]
    public string TableroSerializado { get; set; } = string.Empty;

    [Required]
    public string UsuarioGuardoId { get; set; } = string.Empty;

    [Required]
    public string OponenteId { get; set; } = string.Empty;

    [ForeignKey("UsuarioGuardoId")]
    public ApplicationUser? UsuarioGuardo { get; set; }
}


