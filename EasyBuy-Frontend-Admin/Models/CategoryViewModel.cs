using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EasyBuy_Frontend_Admin.Models
{
    public class CategoryViewModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên là bắt buộc.")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Mô tả là bắt buộc.")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Trạng thái là bắt buộc.")]
        [JsonPropertyName("status")]
        public CategoryStatus Status { get; set; }
    }
	public enum CategoryStatus
	{
		[Display(Name = "Hoạt động")]
		ENABLE = 0,

		[Display(Name = "Không hoạt động")]
		DISABLED = 1
	}
}
