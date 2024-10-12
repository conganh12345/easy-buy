using EasyBuy_Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyBuy_Backend.Data.Configurations
{
    public class InventoryVoucherConfiguration : IEntityTypeConfiguration<InventoryVoucher>
    {
        public void Configure(EntityTypeBuilder<InventoryVoucher> entity)
        {
            entity.ToTable("inventory_vouchers");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id)
                .IsRequired()
                .HasColumnName("id");

            entity.Property(e => e.Date)
                .IsRequired()
                .HasColumnName("date");

            entity.Property(e => e.Total)
                .IsRequired()
                .HasColumnName("total");

            // Thiết lập khóa ngoại cho Supplier
            entity.HasOne(e => e.Supplier)
                .WithMany(s => s.InventoryVouchers) // Liên kết với Suppliers
                .HasForeignKey(e => e.SupplierId)
                .OnDelete(DeleteBehavior.Restrict) // Thiết lập hành động khi xóa
                .HasConstraintName("FK_InventoryVoucher_Supplier");
        }
    }
}
