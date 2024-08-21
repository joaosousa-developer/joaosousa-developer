using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AppBloodWeb.Application.DTOs;

public class TriagemDTO
{
    public int TriagemID { get; set; }
    [Required]
    public DateTime DataTriagem { get; set; }

    [StringLength(50)]
    public string? PressaoArterial { get; set; }

    [Range(0, int.MaxValue)]
    public int Pulso { get; set; }

    [Range(0, 999.99)]
    public double Temperatura { get; set; }

    [Range(0, 999.99)]
    public double Hemoglobina { get; set; }

    public int IdDoador { get; set; }
}
