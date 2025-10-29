using System.ComponentModel.DataAnnotations;

namespace UserManagementAPI.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }

        [Required, EmailAddress(ErrorMessage = "Valid email is required")]
        public string? Email { get; set; }

        public string? Role { get; set; }
    }
}
