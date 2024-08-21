
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AppBloodWeb.Domain.Entities
{
    public class TriagemAptidaoModel
    {
       
            [Key]
            public int AptidaoId { get; set; }

            public string ? Apto { get; set; }
            public string ? MotivoInaptidao { get; set; }
            public string? ObservacoesAdicionais { get; set; }

             

            [ForeignKey("TriagemID")]
            public int TriagemID { get; set; }

            [JsonIgnore]
            public TriagemModel? triagemodel { get; set; }   

        

    }
}
