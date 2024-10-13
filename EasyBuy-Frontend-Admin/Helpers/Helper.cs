using EasyBuy_Frontend_Admin.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
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
				// Kiểm tra từng loại enum
				case CategoryStatus categoryStatus:
					switch (categoryStatus)
					{
						case CategoryStatus.ENABLE:
							return "success";
						case CategoryStatus.DISABLED:
							return "danger";
					}
					break;

				case UserStatus userStatus:
					switch (userStatus)
					{
						case UserStatus.ENABLE:
							return "success";
						case UserStatus.DISABLED:
							return "danger";
					}
					break;

				case UserRole userRole:
					switch (userRole)
					{
						case UserRole.USER:
							return "info";
						case UserRole.ADMIN:
							return "primary";
					}
					break;

				default:
					return "secondary";
			}

			return "secondary"; 
		}
    }
}
