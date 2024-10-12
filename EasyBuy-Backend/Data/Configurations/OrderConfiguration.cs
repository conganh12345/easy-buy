using EasyBuy_Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static EasyBuy_Backend.Models.Order;

namespace EasyBuy_Backend.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> entity)
        {
            entity.ToTable("orders"); // Đặt tên bảng trong cơ sở dữ liệu

            entity.HasKey(e => e.Id); // Đặt Id làm khóa chính

            entity.Property(e => e.Id)
                .IsRequired()
                .HasColumnName("id"); // Đặt tên cột là "id"

            entity.Property(e => e.OrderDate)
                .IsRequired()
                .HasColumnName("order_date"); // Đặt tên cột là "order_date"

            entity.Property(e => e.ShippingFee)
                .IsRequired()
                .HasColumnName("shipping_fee"); // Đặt tên cột là "shipping_fee"

            entity.Property(e => e.OrderDiscount)
                .IsRequired()
                .HasColumnName("order_discount"); // Đặt tên cột là "order_discount"

            entity.Property(e => e.OrderTotal)
                .IsRequired()
                .HasColumnName("order_total"); // Đặt tên cột là "order_total"

            entity.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("address"); // Đặt tên cột là "address"

            entity.Property(e => e.Status)
                .HasConversion(
                    v => v.ToString(),
                    v => (OrderStatus)Enum.Parse(typeof(OrderStatus), v))
                .HasColumnName("status");

            //// Thiết lập khóa ngoại với User
            //entity.HasOne(e => e.User)
            //    .WithMany()
            //    .HasForeignKey(e => e.UserId)
            //    .OnDelete(DeleteBehavior.Restrict) // Thiết lập hành động khi xóa
            //    .HasConstraintName("FK_Order_User");

            //// Thiết lập khóa ngoại với Payment
            //entity.HasOne(e => e.Payment)
            //    .WithMany()
            //    .HasForeignKey(e => e.PaymentId)
            //    .OnDelete(DeleteBehavior.Restrict) // Thiết lập hành động khi xóa
            //    .HasConstraintName("FK_Order_Payment");

            //// Thiết lập khóa ngoại với Voucher
            //entity.HasOne(e => e.Voucher)
            //    .WithMany()
            //    .HasForeignKey(e => e.VoucherId)
            //    .OnDelete(DeleteBehavior.Restrict) // Thiết lập hành động khi xóa
            //    .HasConstraintName("FK_Order_Voucher");
        }
    }
}
