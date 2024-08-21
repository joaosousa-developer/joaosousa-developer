using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AppBloodWeb.Domain.Entities
{
    [Table("Usuario")]
    public class UsuariosModel
    {

        [Key]
        [Required]
        public int Id { get; set; }

        public string? nome { get; set; }
       
        public DateTime Data_nascimento { get; set; }

        public string? municipio { get; set; }
        public string? provincia { get; set; }

        public string? numeroBI { get; set; }
        public string? numerotelefone { get; set; }
        public string? email { get; set; }
        public string? senha { get; set; }

        [ForeignKey("Idpermissao")]
        public int Idpermissao { get; set; }

        [JsonIgnore]
        public PermissaoModel? permissaomodel { get; set; }
        [JsonIgnore]
        public ICollection<AdiministradorModel>? adiministrador { get; set; }
        [JsonIgnore]
        public ICollection<DoadorModel>? doadormodel { get; set; }

    }
}
