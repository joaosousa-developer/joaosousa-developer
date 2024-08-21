using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AppBloodWeb.Domain.Entities
{
    [Table("Doador")]
    public class DoadorModel
    {   
        [Key]
        [Required]
        public int IdDoador { get; set; } // este e o padrao de nomeclatura para ids
        //Pode ser útil adicionar validações adicionais, como limites de comprimento para nome e numeroBI

        public ICollection<AgendaModel> ?agendamodel { get; set; }                    
        public ICollection<BolsaDeSangueModel>? bolsadesangue { get; set; }
        public ICollection<HistoricoDoadorModel>? historicodoadormodel { get; set; }

        public ICollection<TriagemModel> ? triagemodel { get; set; }

        [ForeignKey("Id")]
        public int Id { get; set; }

        [JsonIgnore]
        public UsuariosModel? usuariomodel { get; set; }

        
    }

}

