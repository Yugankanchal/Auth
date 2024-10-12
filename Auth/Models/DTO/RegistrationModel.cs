using System.ComponentModel.DataAnnotations;

namespace Auth.Models.DTO
{
    public class RegistrationModel
    {
        [Required]

        public string? UserName { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? Email { get; set; }
    }
}
