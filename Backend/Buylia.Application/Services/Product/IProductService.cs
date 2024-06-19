using Buylia.Application.Shared;
using Buylia.DTO.Product;

namespace Buylia.Application.Services.Product;

public interface IProductService
{
    Task<IReadOnlyList<ProductDto>> GetProductsAsync(EntityQueryParameters queryParameters);
    Task<ProductDto?> GetProductByIdAsync(int id);
    //Task CreateProductAsync(ProductDto product);
    //void UpdateProduct(ProductDto product);
    //void DeleteProduct(ProductDto product);
}