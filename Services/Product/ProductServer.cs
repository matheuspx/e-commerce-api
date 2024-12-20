using API_CRUD.DataAcess;
using API_CRUD.DTOs;
using API_CRUD.Models;

namespace API_CRUD.Services.Product;

public class ProductService : IProductService
{
    private readonly AppDbContext _context;

    public ProductService(AppDbContext context)
    {
        _context = context;
    }

    public void AddProduct(ProductModel product)
    {
        
        _context.Products.Add(product);
        _context.SaveChanges();
    }
}


