using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace AppBloodWeb.Domain.Entities
{
    [Table("Permissao")]
    public class PermissaoModel
    {
        [Key]
        [Required]
        public int Idpermissao { get; set; }

        public string? Descricao{ get; set; }
      
       
        [JsonIgnore]
        public ICollection<UsuariosModel>? usuariomodel{ get; set; } 
        

        // como fazer entrega de sangue

    }
}
