using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using EasyBuy_Frontend_Admin.Models.Enums;

namespace EasyBuy_Frontend_Admin.Models
{
    public class ProductViewModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên là bắt buộc.")]
        [JsonPropertyName("productName")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Giá bán là bắt buộc.")]
        [Range(0, double.MaxValue, ErrorMessage = "Giá bán không hợp lệ.")]
        [JsonPropertyName("priceToSell")]
        public Double PriceToSell { get; set; }

        [Required(ErrorMessage = "Giá nhập là bắt buộc.")]
        [Range(0, double.MaxValue, ErrorMessage = "Giá nhập không hợp lệ.")]
        [JsonPropertyName("importPrice")]
        public Double ImportPrice { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Giá giảm không hợp lệ.")]
        [JsonPropertyName("discount")]
        public Double? Discount { get; set; }

        [Required(ErrorMessage = "Kiểu là bắt buộc.")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Kiểu phải có độ dài từ 1 đến 200 ký tự.")]
        [JsonPropertyName("model")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Màu sắc là bắt buộc.")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Màu sắc phải có độ dài từ 1 đến 200 ký tự.")]
        [JsonPropertyName("color")]
        public string Color { get; set; }

        [Required(ErrorMessage = "Giới tính là bắt buộc.")]
        [StringLength(3, MinimumLength = 2, ErrorMessage = "Giới tính phải có độ dài từ 2 đến 3 ký tự.")]
        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [StringLength(200, ErrorMessage = "Mô tả có độ dài tối đa 200 ký tự.")]
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Hình ảnh là bắt buộc.")]
        [StringLength(200, ErrorMessage = "Link ảnh phải có độ dài tối đa 200 ký tự.")]
        [JsonPropertyName("productImg")]
		public string ProductImg { get; set; }

		[Required(ErrorMessage = "Có thể xóa là bắt buộc.")]
		[Range(0, int.MaxValue, ErrorMessage = "Có thể xóa không hợp lệ.")]
		[JsonPropertyName("can_del")]
		public int CanDel { get; set; }

		[Required(ErrorMessage = "Số lượng tồn là bắt buộc.")]
		[Range(0, int.MaxValue, ErrorMessage = "Số lượng tồn phải lớn hơn hoặc bằng 0.")]
		[JsonPropertyName("stock_quantity")]
		public int StockQuantity { get; set; }

		[Required(ErrorMessage = "Trạng thái là bắt buộc.")]
        [Range(0, int.MaxValue, ErrorMessage = "Trạng thái không hợp lệ.")]
        [JsonPropertyName("status")]
        public ProductStatus Status { get; set; }

		[Required(ErrorMessage = "id danh mục là bắt buộc.")]
		[Range(0, int.MaxValue, ErrorMessage = "id không hợp lệ.")]
		[JsonPropertyName("categoryId")]
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
	}
}
