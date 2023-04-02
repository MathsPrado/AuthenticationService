using System.ComponentModel.DataAnnotations;

namespace AutenticationService.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }

        [Required]
        public string? Username { get; set; }

        [Required]
        public string? Password { get; set; }

        [Required]
        public string? Role { get; set; }
    }
}
