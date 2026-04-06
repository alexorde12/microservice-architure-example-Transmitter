using TransmitterApi.Domain.Models.Dtos;

namespace TransmitterApi.Infrastructure.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
