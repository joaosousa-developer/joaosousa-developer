
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace AppBloodWeb.Application.DTOs;

public class AdiministradorDTO
{
    
    [Key]
    [Required]
    public int IdAdmin { get; set; }

    // id usuario

    [ForeignKey("Id")]
    public int Id{ get; set; } 

}
