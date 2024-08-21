using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace AppBloodWeb.Application.DTOs;


public class PermissaoDTO
{
    [Key]
    [Required]
    public int Idpermissao { get; set; }
    
    public string? Descricao{ get; set; }


    // como fazer entrega de sangue

}
