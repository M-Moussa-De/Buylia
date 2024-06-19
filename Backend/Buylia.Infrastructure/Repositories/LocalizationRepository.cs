using Buylia.Application.Contracts;
using Buylia.Context;
using Buylia.Model;

namespace Buylia.Infrastructure.Repositories;

public class LocalizationRepository : GenericRepository<Localization>, ILocalizationRepository
{
    public LocalizationRepository(BuyliaDbContext context) : base(context)
    {
    }
}
