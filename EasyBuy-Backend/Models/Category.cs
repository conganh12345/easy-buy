using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace EasyBuy_Backend.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

		public CategoryStatus Status { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }

	public enum CategoryStatus
	{
		[Display(Name = "Hoạt động")]
		ENABLE = 0,

		[Display(Name = "Không hoạt động")]
		DISABLED = 1
	}
}
