using System.ComponentModel.DataAnnotations;

namespace EasyBuy_Backend.Models
{
    public class Supplier
    {
        [Key]
        [Required]
        public int Id { get; set; } // Id của nhà cung cấp

        [Required]
        [StringLength(100)]
        public string Name { get; set; } // Tên nhà cung cấp

        [Required]
        [StringLength(10)]
        public string NumberPhone { get; set; } // Số điện thoại nhà cung cấp

        [Required]
        [StringLength(200)]
        public string Address { get; set; } // Địa chỉ nhà cung cấp

        [Required]
        [StringLength(50)]
        public string Email { get; set; } // Email nhà cung cấp

        [Required]
        public byte Status { get; set; } // Trạng thái nhà cung cấp (0 hoặc 1)
    }
}
