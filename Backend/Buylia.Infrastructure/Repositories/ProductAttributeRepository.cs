using Buylia.Application.Contracts;
using Buylia.Context;
using Buylia.Model;

namespace Buylia.Infrastructure.Repositories;

public class ProductAttributeRepository : GenericRepository<ProductAttribute>, IProductAttributeRepository
{
    public ProductAttributeRepository(BuyliaDbContext context) : base(context)
    {
    }
}
