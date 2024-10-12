using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public SupplierStatus Status { get; set; }

        public virtual ICollection<InventoryVoucher> InventoryVouchers { get; set; } // Liên kết với InventoryVoucher

    }

    public enum SupplierStatus
    {
        [Display(Name = "Hoạt động")]
        ENABLE = 0,

        [Display(Name = "Không hoạt động")]
        DISABLED = 1
    }
}
