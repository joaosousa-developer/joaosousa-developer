
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AppBloodWeb.Application.DTOs;

public class HistoricoDTO
{
    public int Idhistorico { get; set; }
    public DateTime DataDoacao { get; set; } // Data e hora da doação
    public string? TipoDoacao { get; set; } // Tipo de doação (sangue total, plaquetas, plasma, etc.)

    // aqui no historico sera incluida a tabela
    //da triagem para ver as informacoes todas como historico
    [ForeignKey("idDoador")]             // contem informacoes acerca da triagem realizada
    public int IdDoador { get; set; }
   
}
