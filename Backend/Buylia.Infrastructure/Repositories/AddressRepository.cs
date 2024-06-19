using Buylia.Application.Contracts;
using Buylia.Context;
using Buylia.Model;

namespace Buylia.Infrastructure.Repositories;

public class AddressRepository : GenericRepository<Address>, IAddressRepository
{
    public AddressRepository(BuyliaDbContext context) : base(context)
    {
    }
}
