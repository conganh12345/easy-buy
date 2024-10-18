using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EasyBuy_Backend.Models.Enums;


namespace EasyBuy_Backend.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

  
        public string ProductName { get; set; } 

        public double PriceToSell { get; set; }

        public double ImportPrice { get; set; }

        public double? Discount { get; set; } 


        public string Model { get; set; } 


        public string Color { get; set; } 


        public string Gender { get; set; } 

        public string? Description { get; set; }

		public string ProductImg { get; set; }

		public int CanDel { get; set; } = 1; 

        public int StockQuantity { get; set; } 

        public ProductStatus Status { get; set; }

        public int? CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }

        public virtual ICollection<OrderLine>? OrderLines { get; set; } 
        public virtual ICollection<Cart>? Carts { get; set; }
        public virtual ICollection<InventoryVoucherDetail>? InventoryVoucherDetails { get; set; }
    }
}
