using Buylia.Application.Services.Product;
using Microsoft.Extensions.DependencyInjection;

namespace Buylia.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        services.AddScoped<IProductService, ProductService>();

        return services;
    }
}