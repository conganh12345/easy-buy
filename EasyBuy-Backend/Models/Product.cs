using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyBuy_Backend.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(300)]
        public string ProductName { get; set; } 

        [Required]
        public double PriceToSell { get; set; }

        [Required]
        public double ImportPrice { get; set; }

        public double? Discount { get; set; } 

        [Required]
        [StringLength(100)]
        public string Model { get; set; } 

        [Required]
        [StringLength(50)]
        public string Color { get; set; } 

        [Required]
        [StringLength(20)]
        public string Gender { get; set; } 

        public string? Description { get; set; } 

        [Required]
        [StringLength(200)]
        public string ProductImg { get; set; } 

        [Required]
        public int CanDel { get; set; } = 1; 

        public int StockQuantity { get; set; } 

        public ProductStatus Status { get; set; }

        public int? CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public virtual ICollection<OrderLine>? OrderLines { get; set; } 
        public virtual ICollection<Cart>? Carts { get; set; }
        public virtual ICollection<InventoryVoucherDetail>? InventoryVoucherDetails { get; set; }
    }

    public enum ProductStatus
    {
        ENABLE = 0,

        DISABLED = 1
    }
}
