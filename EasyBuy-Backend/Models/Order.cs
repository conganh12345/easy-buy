using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyBuy_Backend.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; } 

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public int ShippingFee { get; set; } 

        [Required]
        public int OrderDiscount { get; set; } 

        [Required]
        public double OrderTotal { get; set; } 

        [Required]
        [StringLength(150)]
        public string Address { get; set; } 

        [Required]
        public OrderStatus Status { get; set; }

        public string? UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public int? PaymentId { get; set; }

        [ForeignKey("PaymentId")]
        public Payment Payment { get; set; }

        public int? VoucherId { get; set; }

        [ForeignKey("VoucherId")]
        public Voucher Voucher { get; set; }

        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }

    public enum OrderStatus
    {
        SUCCESS = 0,

        CANCELED = 1,

        PENDING = 2
    }
}
