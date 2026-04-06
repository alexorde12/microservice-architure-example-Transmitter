using Microsoft.EntityFrameworkCore;
using TransmitterApi.Domain.Models.Dtos;
using TransmitterApi.Domain.Models.Schema;
using TransmitterApi.Infrastructure.Data;
using TransmitterApi.Infrastructure.Repositories.Interfaces;

namespace TransmitterApi.Infrastructure.Repositories
{
    public class ProductRepository(AppDbContext context) : IProductRepository
    {
        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            return await context.Products.Select(x => new ProductDto
            {
                Name = x.Name,
                Price = x.Price
            }).ToListAsync();
        }
    }
}
