using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyBuy_Backend.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; } 

        [Required]
        [StringLength(50)]
        public string Name { get; set; } 

        [Required]
        [EmailAddress]
        public string Email { get; set; } 

        [StringLength(15)]
        public string? Phone { get; set; } 

        [Required]
        public string Password { get; set; } 

        [Required]
        [StringLength(50)]
        public string Address { get; set; } 

        [Required]
        public UserStatus Status { get; set; }

        [Required]
        public UserRole Role { get; set; } 

        public virtual ICollection<Order> Orders { get; set; } 

        public virtual ICollection<Cart> Carts { get; set; }
    }

    public enum UserStatus
    {
        [Display(Name = "Hoạt động")]
        ENABLE = 0,

        [Display(Name = "Không hoạt động")]
        DISABLED = 1
    }

    public enum UserRole
    {
        [Display(Name = "Người dùng")]
        USER = 0,

        [Display(Name = "Quản trị viên")]
        ADMIN = 1
    }
}
