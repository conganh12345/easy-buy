using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyBuy_Backend.Models
{
    public class InventoryVoucherDetail
    {
        [Key]
        public int Id { get; set; } // Khóa chính

        [Required]
        public int Quantity { get; set; } // Số lượng sản phẩm nhận

        [Required]
        public double ReceivingUnitPrice { get; set; } // Giá đơn vị của sản phẩm nhận

        // Khóa ngoại liên kết với InventoryVoucher
        public int InventoryVoucherId { get; set; }
        [ForeignKey("InventoryVoucherId")]
        public InventoryVoucher InventoryVoucher { get; set; } // Liên kết với phiếu nhập kho

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
