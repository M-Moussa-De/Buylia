using Buylia.Application.Contracts;
using Buylia.Context;
using Buylia.Model;

namespace Buylia.Infrastructure.Repositories;

public class ProductColorRepository : GenericRepository<ProductColor>, IProductColorRepository
{
    public ProductColorRepository(BuyliaDbContext context) : base(context)
    {
    }
}
