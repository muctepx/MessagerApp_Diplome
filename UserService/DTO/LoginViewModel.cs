using System.ComponentModel.DataAnnotations;

namespace UserService.DTO
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(8)] 
        public string Password { get; set; }
        public Guid Id { get; set; }
        public RoleType UserRole { get; set; } = RoleType.User;
    }
}
