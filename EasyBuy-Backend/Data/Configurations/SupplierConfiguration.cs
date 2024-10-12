using EasyBuy_Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyBuy_Backend.Data.Configurations
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> entity)
        {
            entity.ToTable("suppliers");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id)
                .IsRequired()
                .HasColumnName("id"); // Đặt tên cột là "id"

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnName("name");

            entity.Property(e => e.NumberPhone)
                .HasMaxLength(10)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnName("number_phone");

            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnName("address");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnName("email");

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("status");
           
        }
    }
}
