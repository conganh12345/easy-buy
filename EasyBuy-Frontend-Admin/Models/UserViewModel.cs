using System.ComponentModel.DataAnnotations;

namespace EasyBuy_Frontend_Admin.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string? Phone { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
