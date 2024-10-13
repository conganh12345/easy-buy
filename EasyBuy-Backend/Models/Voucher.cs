using System;
using System.ComponentModel.DataAnnotations;

namespace EasyBuy_Backend.Models
{
    public class Voucher
    {
        [Key]
        public int Id { get; set; } 

        [Required]
        [StringLength(50)]
        public string VoucherName { get; set; }

        [Required]
        public int Discount { get; set; }

        [Required]
        [StringLength(5)]
        public string Unit { get; set; } 

        [Required]
        public DateTime DateFrom { get; set; } 

        [Required]
        public DateTime DateTo { get; set; }

        [Required]
        public VoucherStatus Status { get; set; }

        public virtual ICollection<Order>? Orders { get; set; }
    }

    public enum VoucherStatus
    {
        [Display(Name = "Hoạt động")]
        ENABLE = 0,

        [Display(Name = "Không hoạt động")]
        DISABLED = 1
    }
}
