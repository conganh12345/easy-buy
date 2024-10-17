using EasyBuy_Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EasyBuy_Backend.Models.Enums;

namespace EasyBuy_Backend.Data.Configurations
{
    public class VoucherConfiguration : IEntityTypeConfiguration<Voucher>
    {
        public void Configure(EntityTypeBuilder<Voucher> entity)
        {
            entity.ToTable("vouchers");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id)
                .IsRequired()
                .HasColumnName("VoucherID"); 

            entity.Property(e => e.VoucherName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("VoucherName"); 

            entity.Property(e => e.Discount)
                .IsRequired()
                .HasColumnName("Discount"); 

            entity.Property(e => e.Unit)
                .IsRequired()
                .HasMaxLength(5)
                .HasColumnName("Unit"); 

            entity.Property(e => e.DateFrom)
                .IsRequired()
                .HasColumnName("DateFrom"); 

            entity.Property(e => e.DateTo)
                .IsRequired()
                .HasColumnName("DateTo"); 

            entity.Property(e => e.Status)
                .HasConversion(
                    v => v.ToString(),
                    v => (VoucherStatus)Enum.Parse(typeof(VoucherStatus), v))
                .HasColumnName("Status"); 
        }
    }
}
