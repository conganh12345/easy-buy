using Microsoft.EntityFrameworkCore;
using EasyBuy_Backend.Models;

namespace EasyBuy_Backend.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) 
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
