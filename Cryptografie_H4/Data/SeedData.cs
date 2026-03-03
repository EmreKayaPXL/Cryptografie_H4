using Cryptografie_H4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Cryptografie_H4.Data
{
    public class SeedData
    {
        public static void EnsureData(WebApplication app)
        {
            try
            {
                using (var scope = app.Services.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<GebruikerDbContext>();

                    context.Database.Migrate();

                    if (!context.Gebruiker.Any())
                    {
                        context.Gebruiker.AddRange(DefaultData.gebruiker);
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
    }
}