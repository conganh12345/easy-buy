using EasyBuy_Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyBuy_Backend.Data.Configurations
{
    public class VoucherConfiguration : IEntityTypeConfiguration<Voucher>
    {
        public void Configure(EntityTypeBuilder<Voucher> entity)
        {
            entity.ToTable("vouchers"); // Tên bảng trong cơ sở dữ liệu

            entity.HasKey(e => e.Id); // Đặt Id làm khóa chính

            entity.Property(e => e.Id)
                .IsRequired()
                .HasColumnName("id"); // Đặt tên cột là "id"

            entity.Property(e => e.VoucherName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("voucher_name"); // Đặt tên cột là "voucher_name"

            entity.Property(e => e.Discount)
                .IsRequired()
                .HasColumnName("discount"); // Đặt tên cột là "discount"

            entity.Property(e => e.Unit)
                .IsRequired()
                .HasMaxLength(5)
                .HasColumnName("unit"); // Đặt tên cột là "unit"

            entity.Property(e => e.DateFrom)
                .IsRequired()
                .HasColumnName("date_from"); // Đặt tên cột là "date_from"

            entity.Property(e => e.DateTo)
                .IsRequired()
                .HasColumnName("date_to"); // Đặt tên cột là "date_to"

            entity.Property(e => e.Status)
                .HasConversion(
                    v => v.ToString(),
                    v => (VoucherStatus)Enum.Parse(typeof(VoucherStatus), v))
                .HasColumnName("status");
        }
    }
}
