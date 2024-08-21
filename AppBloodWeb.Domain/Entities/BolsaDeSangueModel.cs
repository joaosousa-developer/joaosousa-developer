using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AppBloodWeb.Domain.Entities
{
   
        [Table("BolsaDeSangue")]
        public class BolsaDeSangueModel
        {
            [Key]
            [Required]
            public int Idbolsa { get; set; }

            
      
            public string? TipoSanguineo { get; set; }
            public double VolumeMl { get; set; }



            [ForeignKey("IdDoador")] // Indica que IdDoador é uma chave estrangeira
            public int IdDoador { get; set; }
            [JsonIgnore]
            public DoadorModel? doadormodel { get; set; }

         

            //Isso significa que um único doador pode estar associado a várias bolsas de 
            //sangue (por exemplo, várias doações feitas pelo mesmo doador).

        }
    }

