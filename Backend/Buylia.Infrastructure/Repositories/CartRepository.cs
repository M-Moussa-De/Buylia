using Buylia.Application.Contracts;
using Buylia.Context;
using Buylia.Model;

namespace Buylia.Infrastructure.Repositories;

public class CartRepository : GenericRepository<Cart>, ICartRepository
{
    public CartRepository(BuyliaDbContext context) : base(context)
    {
    }
}