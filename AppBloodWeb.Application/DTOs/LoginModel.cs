
using System.ComponentModel.DataAnnotations;
namespace AppBloodWeb.Application.DTOs
{
    public class LoginModel
    {
        [Required(ErrorMessage = "User name is required")]
        public string? UserName { get; set; }


        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }
}
