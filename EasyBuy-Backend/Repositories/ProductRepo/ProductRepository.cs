using EasyBuy_Backend.Data;
using EasyBuy_Backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EasyBuy_Backend.Repositories.ProductRepo;
public class ProductRepository : Repository<Product>, IProductRepository
{
    private readonly MyDbContext _context;

    public ProductRepository(MyDbContext context) : base(context)
    {
        _context = context;
    }
	//public bool Create(Product product)
	//{
	//	try
	//	{
	//		_context.Set<Product>().Add(product);
	//		_context.SaveChanges();

	//		return true;
	//	}
	//	catch (Exception ex)
	//	{
	//		Debug.WriteLine($"Unexpected error: {ex.Message}");
	//		return false;
	//	}
	//}
}
