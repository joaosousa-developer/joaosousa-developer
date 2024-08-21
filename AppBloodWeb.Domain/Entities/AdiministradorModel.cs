
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace AppBloodWeb.Domain.Entities
{
    [Table("Adiministrador")]
    public class AdiministradorModel
    {
        
        [Key]
        [Required]
        public int IdAdmin { get; set; }

        [ForeignKey("Id")]
        public int Id{ get; set; }

        [JsonIgnore]
        public UsuariosModel ? usuariomodel { get; set; }
        
        //como fazer pedidos de sangue 

    }
}
