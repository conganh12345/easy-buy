using EasyBuy_Backend.Data;
using EasyBuy_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyBuy_Backend.Repositories.ProductRepo;
public class ProductRepository : Repository<Product>, IProductRepository
{
    private readonly MyDbContext _context;

        public ProductRepository(MyDbContext context) : base(context)
        {
            _context = context;
        }

    //public async Task<Product> GetByEmailAsync(string email)
    //{
    //    return await _context.Set<Product>().FirstOrDefaultAsync(u => u.Email == email);
    //}

    //public async Task<Product> GetProductIdAsStringAsync(string id)
    //{
    //    return await _context.Set<Product>().FirstOrDefaultAsync(u => u.Id == id);
    //}
}
