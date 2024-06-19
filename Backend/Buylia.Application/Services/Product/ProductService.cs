using AutoMapper;
using Buylia.Application.Contracts;
using Buylia.Application.Shared;
using Buylia.DTO.Product;

namespace Buylia.Application.Services.Product;

public class ProductService : IProductService
{
    private readonly IUnitOfWork<Model.Product> _unitOfWork;
    private readonly IMapper _mapper;

    public ProductService(IUnitOfWork<Model.Product> unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IReadOnlyList<ProductDto>> GetProductsAsync(EntityQueryParameters queryParameters)
    {
        var products = await _unitOfWork.GenericRepository.GetAllAsync(queryParameters);

        return _mapper.Map<IReadOnlyList<ProductDto>>(products);       
    }

    public async Task<ProductDto?> GetProductByIdAsync(int id)
    {
        var product = await _unitOfWork.GenericRepository.GetByIdAsync(id);

        if (product == null)
        {
            return null;
        }

        return _mapper.Map<ProductDto>(product);
    }
}