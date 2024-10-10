using EasyBuy_Frontend_Admin.Models;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace EasyBuy_Frontend_Admin.Helpers
{
	public static class Helper
	{
		//Lấy ra tên display name của enum khi show
		public static string GetDisplayName(this Enum enumValue)
		{
			return enumValue.GetType()
							.GetMember(enumValue.ToString())
							.First()
							.GetCustomAttribute<DisplayAttribute>()?.Name ?? enumValue.ToString();
		}

		public static string GetBadge(this Enum enumValue)
		{
			switch (enumValue)
			{
				case CategoryStatus.ENABLE:
					return "success";  
				case CategoryStatus.DISABLED:
					return "danger";  
				default:
					return "secondary"; 
			}
		}
	}
}
