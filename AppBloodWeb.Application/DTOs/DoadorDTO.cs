using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AppBloodWeb.Application.DTOs;


public class DoadorDTO {   
    [Key]
    [Required]
    public int IdDoador { get; set; } 
    
    // este e o padrao de nomeclatura para ids
    //Pode ser útil adicionar validações adicionais,
    //como limites de comprimento para nome e numeroBI


    [ForeignKey("Id")]
    public int Id { get; set; }

}

