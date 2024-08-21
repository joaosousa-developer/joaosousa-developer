
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AppBloodWeb.Application.DTOs;

public class BolsaDTO
{

    public int Idbolsa { get; set; }
    public string? TipoSanguineo { get; set; }
    public double VolumeMl { get; set; }


    // Indica que IdDoador é uma chave estrangeira
    [ForeignKey("IdDoador")] 
    public int IdDoador { get; set; }
   

}
