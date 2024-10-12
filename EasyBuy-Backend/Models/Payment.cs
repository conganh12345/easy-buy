using System.ComponentModel.DataAnnotations;

namespace EasyBuy_Backend.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; } // Khóa chính

        [Required]
        [StringLength(50)]
        public string PaymentName { get; set; } // Tên phương thức thanh toán

        public virtual ICollection<Order> Orders { get; set; }
    }
}
