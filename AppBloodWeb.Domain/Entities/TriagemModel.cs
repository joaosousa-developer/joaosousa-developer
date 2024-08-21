
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace AppBloodWeb.Domain.Entities;
public class TriagemModel
{
    [Key]
  
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


    [ForeignKey("IdDoador")]
    public int IdDoador { get; set; }

    [JsonIgnore]
    public DoadorModel ?doadormodel { get; set; }
    [JsonIgnore]
    public TriagemAptidaoModel? triagemaptidaomodel { get; set; }
    [JsonIgnore]
    public TriagemDetalhesModel? triagemdetalhesmodel { get; set; }


}
