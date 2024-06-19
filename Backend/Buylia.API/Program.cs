using Buylia.Context;
using Buylia.Context.Extensions;
using Buylia.Infrastructure.Extensions;
using Buylia.Application.Extensions;
using Buylia.Context.Seeds;
using Microsoft.EntityFrameworkCore;
using Buylia.API.Middleware;

var builder = WebApplication.CreateBuilder(args);

// =============== Services ===============
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Extensions
builder.Services.AddPersistence(builder.Configuration)
                .AddInfrastructure()
                .AddApplication();
#endregion

// =============== Middelware ===============
var app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.ConfigObject.AdditionalItems.Add("persistAuthorization", true);
    });
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

#region Seeders
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var dbContext = services.GetRequiredService<BuyliaDbContext>();
    var loggerFactory = services.GetRequiredService<ILoggerFactory>();
    try
    {
        await dbContext.Database.MigrateAsync();
        await DbInitializer.Initialize(dbContext);
    }
    catch (Exception ex)
    {
        var logger = loggerFactory.CreateLogger<Program>();
        logger.LogError(ex, "An error occurred while seeding the database.");
    }
}
#endregion

app.Run();