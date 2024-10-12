using System;
using System.ComponentModel.DataAnnotations;

namespace EasyBuy_Backend.Models
{
    public class Voucher
    {
        [Key]
        public int Id { get; set; } // ID của voucher

        [Required]
        [StringLength(50)]
        public string VoucherName { get; set; } // Tên của voucher

        [Required]
        public int Discount { get; set; } // Mức giảm giá

        [Required]
        [StringLength(5)]
        public string Unit { get; set; } // Đơn vị của giảm giá

        [Required]
        public DateTime DateFrom { get; set; } // Ngày bắt đầu hiệu lực

        [Required]
        public DateTime DateTo { get; set; } // Ngày kết thúc hiệu lực

        [Required]
        public VoucherStatus Status { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }

    public enum VoucherStatus
    {
        [Display(Name = "Hoạt động")]
        ENABLE = 0,

        [Display(Name = "Không hoạt động")]
        DISABLED = 1
    }
}
