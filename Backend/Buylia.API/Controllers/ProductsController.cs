using Buylia.Application.Services.Product;
using Buylia.Application.Shared;
using Buylia.DTO.Product;
using Microsoft.AspNetCore.Mvc;

namespace Buylia.API.Controllers;

public class ProductsController : BaseController
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<ICollection<ProductDto>> GetAllProductsAsync([FromQuery] EntityQueryParameters queryParams)
    {
        var products = await _productService.GetProductsAsync(queryParams);

        return products.ToList();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProductDto?>> GetProductByIdAsync(int id)
    {
        var product = await _productService.GetProductByIdAsync(id);

        if (product == null) return NotFound();

        return product;
    }
}