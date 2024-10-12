using EasyBuy_Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyBuy_Backend.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.ToTable("users");

            entity.HasKey(e => e.Id); // Đặt khóa chính cho Id

            entity.Property(e => e.Id)
                .HasColumnName("id");

            entity.Property(e => e.Name)
                .IsRequired() // Tên bắt buộc
                .HasMaxLength(50) // Tối đa 50 ký tự
                .IsUnicode(false)
                .HasColumnName("name");

            entity.Property(e => e.Email)
                .IsRequired() // Email bắt buộc
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");

            entity.Property(e => e.Phone)
                .HasMaxLength(15) // Tối đa 15 ký tự
                .HasColumnName("phone");

            entity.Property(e => e.Password)
                .IsRequired() // Mật khẩu bắt buộc
                .HasMaxLength(255)
                .HasColumnName("password");

            entity.Property(e => e.Address) // Thêm thuộc tính Address
                .IsRequired() // Địa chỉ bắt buộc
                .HasMaxLength(50) // Tối đa 50 ký tự
                .HasColumnName("address");

            entity.Property(e => e.Status)
               .HasConversion(
                   v => v.ToString(),
                   v => (UserStatus)Enum.Parse(typeof(UserStatus), v))
               .HasColumnName("status");
        }
    }
}
