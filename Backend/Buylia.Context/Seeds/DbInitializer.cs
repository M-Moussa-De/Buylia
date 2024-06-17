using Buylia.Model;
using System.Text.Json;

namespace Buylia.Context.Seeds;

public static class DbInitializer
{
    private static readonly string filePathBase = "./DataJson/";

    public static void Initialize(BuyliaDbContext context)
    {
        context.Database.EnsureCreated();

        if (!context.Categories.Any())
        {
            var categories = GetDataFromJson<List<Category>>("Categories.json");

            if (categories != null)
            {
                context.Categories.AddRange(categories);
                context.SaveChanges();
            }
        }

        if (!context.Products.Any())
        {
            var products = GetDataFromJson<List<Product>>("Products.sjon");

            if (products != null)
            {
                context.Products.AddRange(products);
                context.SaveChanges();
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
