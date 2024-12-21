using System.ComponentModel.DataAnnotations;

namespace ProductosApi.Models;
public class ProductosInsert
{
    [Required]
    [MaxLength(50)]
    public string Nombre { get; set; } = string.Empty;
    [Required]
    [MaxLength(50)]
    public string Marca { get; set; } = string.Empty;
    [Required]
    [Range(0, 999)]
    public double Alto { get; set; }
    [Required]
    [Range(0, 999)]
    public double Ancho { get; set; }
    [Required]
    [Range(0, 999)]
    public double Profundidad { get; set; }
    [Range(0, 999)]
    public double Peso { get; set; }
}
