using System.ComponentModel.DataAnnotations;

namespace EKart.API.DTOs.Request
{
    public class RegisterRequestDTO
    {
        [Required]
        public string? UserName { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public bool? IsSeller { get; set; }
    }
}
