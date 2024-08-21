using System.ComponentModel.DataAnnotations.Schema;

namespace AppBloodWeb.Application.DTOs;

public class AgendaDTO
{

    public int IdAgenda { get; set; }
    // Data específica para a doação
    public DateTime Data { get; set; }



    // Indica que IdDoador é uma chave estrangeira
    [ForeignKey("IdDoador")] 
    public int IdDoador { get; set; }
}
