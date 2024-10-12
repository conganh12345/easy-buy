using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyBuy_Backend.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; } // Khóa chính

        [Required]
        [Range(1, 999)] // Giới hạn số lượng từ 1 đến 999
        public int Quantity { get; set; } // Số lượng sản phẩm trong giỏ hàng

        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        public int? ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
