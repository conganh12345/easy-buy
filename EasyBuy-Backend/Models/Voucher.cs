using System;
using EasyBuy_Backend.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace EasyBuy_Backend.Models
{
    public class Voucher
    {
        [Key]
        public string Id { get; set; } 

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

        //public virtual ICollection<Order>? Orders { get; set; }
    }
}
