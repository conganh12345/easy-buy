using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyBuy_Backend.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; } // Khóa chính

        [Required]
        public DateTime OrderDate { get; set; } // Ngày đặt hàng

        [Required]
        public int ShippingFee { get; set; } // Phí giao hàng

        [Required]
        public int OrderDiscount { get; set; } // Giảm giá đơn hàng

        [Required]
        public double OrderTotal { get; set; } // Tổng đơn hàng

        [Required]
        [StringLength(150)]
        public string Address { get; set; } // Địa chỉ giao hàng

        [Required]
        public OrderStatus Status { get; set; } // Trạng thái đơn hàng

        public int? UserId { get; set; }
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
        [Display(Name = "Thành công")]
        SUCCESS = 0,

        [Display(Name = "Đã hủy")]
        CANCELED = 1,

        [Display(Name = "Đang xét duyệt")]
        PENDING = 2
    }
}
