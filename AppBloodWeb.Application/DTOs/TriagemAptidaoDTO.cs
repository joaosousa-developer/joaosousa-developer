
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BloodWebAPI.DTOs;
    public class TriagemAptidaoDTO
    {
       
            [Key]
            public int AptidaoId { get; set; }

            public string ? Apto { get; set; }
            public string ? MotivoInaptidao { get; set; }
            public string? ObservacoesAdicionais { get; set; }

             

            [ForeignKey("TriagemID")]
            public int TriagemID { get; set; }

          

        

    }

