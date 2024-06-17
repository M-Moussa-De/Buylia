using Buylia.Model;
using System.Text.Json;

namespace Buylia.Context.Seeds;

public static class DbInitializer
{
    private static readonly string filePathBase 
        = "../Buylia.Context/DataJson/";

    public static async Task Initialize(BuyliaDbContext context)
    {
        context.Database.EnsureCreated();

        if (!context.Categories.Any())
        {
            var categories = GetDataFromJson<List<Category>>("Categories.json");

            if (categories != null)
            {
               context.Categories.AddRange(categories);
               await context.SaveChangesAsync();
            }
        }

        if (!context.Sellers.Any())
        {
            var sellers = GetDataFromJson<List<Seller>>("Sellers.json");

            if (sellers != null)
            {
               context.Sellers.AddRange(sellers);
               await context.SaveChangesAsync();
            }
        }

        if (!context.Products.Any())
        {
            var products = GetDataFromJson<List<Product>>("Products.json");

            if (products != null)
            {
                context.Products.AddRange(products);
                await context.SaveChangesAsync();
            }
        }
    }

    private static T? GetDataFromJson<T>(string fileName)
    {
        string filePath = Path.Combine(filePathBase, fileName);

        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"File not found at {filePath}");
        }

        var json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<T>(json);
    }
}
