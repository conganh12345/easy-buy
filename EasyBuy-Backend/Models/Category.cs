using System.ComponentModel.DataAnnotations;
using System.Reflection;
using EasyBuy_Backend.Models.Enums;

namespace EasyBuy_Backend.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

		public CategoryStatus Status { get; set; }

        public virtual ICollection<Product>? Products { get; set; }
    }
}
