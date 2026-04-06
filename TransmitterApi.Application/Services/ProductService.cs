using TransmitterApi.Application.Services.Interfaces;
using TransmitterApi.Domain.Models.Dtos;
using TransmitterApi.Infrastructure.Repositories.Interfaces;

namespace TransmitterApi.Application.Services
{
    public class ProductService(IProductRepository productRepository) : IProductService
    {
        public async Task<IEnumerable<ProductDto>> GetProducts() => await productRepository.GetProducts();
    }
}
