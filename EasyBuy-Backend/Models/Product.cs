using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyBuy_Backend.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; } // Khóa chính

        [Required]
        [StringLength(300)]
        public string ProductName { get; set; } // Tên sản phẩm

        [Required]
        public double PriceToSell { get; set; } // Giá bán

        [Required]
        public double ImportPrice { get; set; } // Giá nhập

        public double? Discount { get; set; } // Giảm giá (có thể để trống)

        [Required]
        [StringLength(100)]
        public string Model { get; set; } // Mô hình sản phẩm

        [Required]
        [StringLength(50)]
        public string Color { get; set; } // Màu sắc sản phẩm

        [Required]
        [StringLength(20)]
        public string Gender { get; set; } // Giới tính (nam/nữ)

        public string? Description { get; set; } // Mô tả sản phẩm (có thể để trống)

        [Required]
        [StringLength(200)]
        public string ProductImg { get; set; } // Hình ảnh sản phẩm

        [Required]
        public int CanDel { get; set; } = 1; // Có thể xóa hay không (mặc định là 1)

        public int StockQuantity { get; set; } // Số lượng hàng tồn kho

        public ProductStatus Status { get; set; }

        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public virtual ICollection<OrderLine> OrderLines { get; set; } // Liên kết với InventoryVoucher
        public virtual ICollection<Cart> Carts { get; set; }
    }

    public enum ProductStatus
    {
        [Display(Name = "Hoạt động")]
        ENABLE = 0,

        [Display(Name = "Không hoạt động")]
        DISABLED = 1
    }
}
