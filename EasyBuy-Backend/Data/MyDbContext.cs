using Microsoft.EntityFrameworkCore;
using EasyBuy_Backend.Models;
using EasyBuy_Backend.Data.Configurations;

namespace EasyBuy_Backend.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) 
        {
            //
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<InventoryVoucher> InventoryVouchers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            modelBuilder.ApplyConfiguration(new SupplierConfiguration());

            modelBuilder.ApplyConfiguration(new CategoryConfiguration());

            modelBuilder.ApplyConfiguration(new InventoryVoucherConfiguration());
        }      
    }
}
