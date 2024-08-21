using System.ComponentModel.DataAnnotations.Schema;

namespace AppBloodWeb.Application.DTOs;

public class UsuarioDTO
{
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

}
