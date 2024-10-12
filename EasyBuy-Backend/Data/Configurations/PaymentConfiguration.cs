using EasyBuy_Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyBuy_Backend.Data.Configurations
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> entity)
        {
            entity.ToTable("payments"); // Tên bảng trong cơ sở dữ liệu

            entity.HasKey(e => e.Id); // Đặt Id làm khóa chính

            entity.Property(e => e.Id)
                .IsRequired()
                .HasColumnName("id"); // Đặt tên cột là "id"

            entity.Property(e => e.PaymentName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("payment_name"); // Đặt tên cột là "payment_name"
        }
    }
}
