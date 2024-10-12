using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyBuy_Backend.Models
{
    public class OrderLine
    {
        [Key]
        public int Id { get; set; } // Khóa chính

        [Required]
        public int Quantity { get; set; } // Số lượng sản phẩm

        [Required]
        public double UnitPrice { get; set; } // Giá đơn vị của sản phẩm

        // Thêm khóa ngoại để liên kết với Order
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; } // Liên kết với đơn hàng

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
