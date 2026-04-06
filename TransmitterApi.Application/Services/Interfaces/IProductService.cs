using TransmitterApi.Domain.Models.Dtos;

namespace TransmitterApi.Application.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
