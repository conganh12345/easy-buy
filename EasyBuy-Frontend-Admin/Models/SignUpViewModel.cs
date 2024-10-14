using System.ComponentModel.DataAnnotations;
using EasyBuy_Frontend_Admin.Models.Enums;


namespace EasyBuy_Frontend_Admin.Models
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage = "Tên là bắt buộc.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email là bắt buộc.")]
        [EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Số điện thoại là bắt buộc.")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Mật khẩu là bắt buộc.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Mật khẩu phải có độ dài từ 6 đến 100 ký tự.")]
        public string Password { get; set; }

        public string Address { get; set; } = "Chưa có địa chỉ"; 

        public UserStatus Status { get; set; } = UserStatus.ENABLE; 

        public UserRole Role { get; set; } = UserRole.USER;
    }
}
