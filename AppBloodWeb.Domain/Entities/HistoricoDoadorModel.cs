using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace AppBloodWeb.Domain.Entities
{
    [Table("HistoricoDoador")]
    public class HistoricoDoadorModel
    {
        [Key]
        [Required]
        public int Idhistorico { get; set; } // ID exclusivo para cada entrada no histórico
                                             // ID do doador associado a esta entrada
        public DateTime DataDoacao { get; set; } // Data e hora da doação
        public string? TipoDoacao { get; set; } // Tipo de doação (sangue total, plaquetas, plasma, etc.)
       
                                               // aqui no historico sera incluida a tabela
                                              //da triagem para ver as informacoes todas como historico
        [ForeignKey("idDoador")]             // contem informacoes acerca da triagem realizada
        public int IdDoador { get; set; }
        [JsonIgnore]
        public DoadorModel? doadormodel { get; set; }

        // Lembre-se de que a doação de sangue é fundamental para manter os estoques e salvar vidas. Seja um doador!

        // Outras propriedades relevantes podem ser adicionadas conforme necessário
    }


}
