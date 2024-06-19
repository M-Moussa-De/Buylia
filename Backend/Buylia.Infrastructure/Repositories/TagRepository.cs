using Buylia.Application.Contracts;
using Buylia.Context;
using Buylia.Model;

namespace Buylia.Infrastructure.Repositories;

public class TagRepository : GenericRepository<Tag>, ITagRepository
{
    public TagRepository(BuyliaDbContext context) : base(context)
    {
    }
}
