using EasyBuy_Frontend_Admin.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EasyBuy_Frontend_Admin.Models
{
    public class SupplierViewModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên là bắt buộc.")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "SDT là bắt buộc.")]
        [JsonPropertyName("number_phone")]
        public string Number_phone { get; set; }

        [Required(ErrorMessage = "Địa chỉ là bắt buộc.")]
        [JsonPropertyName("address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Email là bắt buộc.")]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Trạng thái là bắt buộc.")]
        [JsonPropertyName("status")]
        public SupplierStatus Status { get; set; }
    }
}
