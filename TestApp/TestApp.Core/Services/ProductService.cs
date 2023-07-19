using Microsoft.EntityFrameworkCore;
using TestApp.Contracts.Models;
using TestApp.Database;

namespace TestApp.Services;

public interface IProductService
{
    Task<List<ProductPc>> GetProductsAsync(CancellationToken cancellationToken = default);
}

public class ProductService : IProductService
{
    private readonly StoreDbContext _context;

    public ProductService(StoreDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<ProductPc>> GetProductsAsync(CancellationToken cancellationToken = default)
    {
        var items = await _context.Products.ToListAsync(cancellationToken);

        return items.Select(z => new ProductPc()
        {
            Id = z.Id,
            Name = z.Name,
            Description = z.Description
        }).ToList();
    }
}