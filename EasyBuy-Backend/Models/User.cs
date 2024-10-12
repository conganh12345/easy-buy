using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyBuy_Backend.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; } // Khóa chính

        [Required]
        [StringLength(50)]
        public string Name { get; set; } // Tên người dùng

        [Required]
        [EmailAddress]
        public string Email { get; set; } // Email người dùng

        [StringLength(15)]
        public string? Phone { get; set; } // Số điện thoại người dùng

        [Required]
        public string Password { get; set; } // Mật khẩu người dùng

        [Required]
        [StringLength(50)]
        public string Address { get; set; } // Địa chỉ người dùng

        [Required]
        public UserStatus Status { get; set; }

        public virtual ICollection<Order> Orders { get; set; } // Danh sách đơn hàng của người dùng

        public virtual ICollection<Cart> Carts { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }

    public enum UserStatus
    {
        [Display(Name = "Hoạt động")]
        ENABLE = 0,

        [Display(Name = "Không hoạt động")]
        DISABLED = 1
    }
}
