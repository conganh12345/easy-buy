using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EasyBuy_Backend.Models.Enums;


namespace EasyBuy_Backend.Models
{
    public class Supplier
    {
        [Key]
        [Required]
        public int Id { get; set; } 

        [Required]
        [StringLength(100)]
        public string Name { get; set; } 

        [Required]
        [StringLength(10)]
        public string NumberPhone { get; set; } 

        [Required]
        [StringLength(200)]
        public string Address { get; set; } 

        [Required]
        [StringLength(50)]
        public string Email { get; set; } 

        [Required]
        public SupplierStatus Status { get; set; }

        public virtual ICollection<InventoryVoucher>? InventoryVouchers { get; set; } 
    }
}
