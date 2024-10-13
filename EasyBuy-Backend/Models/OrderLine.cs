using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyBuy_Backend.Models
{
    public class OrderLine
    {
        [Key]
        public int Id { get; set; } 

        [Required]
        public int Quantity { get; set; } 

        [Required]
        public double UnitPrice { get; set; } 

        public int OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; } 

        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
