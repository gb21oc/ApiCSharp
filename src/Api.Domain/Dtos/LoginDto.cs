using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos
{
    public class LoginDto
    {

        [Required (ErrorMessage = "Email é campo obrigatorio para Login")]
        [EmailAddress(ErrorMessage = "E-mail em formato invalido")]
        [StringLength(100, ErrorMessage = "Email deve ter no maximo {1} caracteres")]
        public string Email { get; set; }
    }
}