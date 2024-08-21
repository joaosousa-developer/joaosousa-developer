
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AppBloodWeb.Application.DTOs;


public class TriagemDetalhesDTO
{
    
    public int detalhesId { get; set; }
    public string? HistoricoDoencas { get; set; }

    public string? Medicamentos { get; set; }

    public string? Alergias { get; set; }

    public string? ViagensRecentes { get; set; }


    [DataType(DataType.Text)]
    public string? ComportamentoRisco { get; set; }

   
    public int triagemId { get; set; }
       
}
