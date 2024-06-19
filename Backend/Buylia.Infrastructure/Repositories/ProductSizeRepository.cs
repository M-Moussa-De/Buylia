using Buylia.Application.Contracts;
using Buylia.Context;
using Buylia.Model;

namespace Buylia.Infrastructure.Repositories;

internal class ProductSizeRepository : GenericRepository<ProductSize>, IProductSizeRepository
{
    public ProductSizeRepository(BuyliaDbContext context) : base(context)
    {
    }
}
