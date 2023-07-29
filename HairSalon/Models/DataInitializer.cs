// FOR DEVELOPMENT ONLY
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
public static class DataInitializer
{
    public static void InitializeData(WebApplication app)
    {
        // Database initialization
        using (var scope = app.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            try
            {
                var context = services.GetRequiredService<HairSalonContext>();
                context.Database.Migrate(); // Applies any pending migrations

                // Seeding data
                if (!context.Stylists.Any()) // Checks if there are any Stylists
                {
                    context.Stylists.AddRange(
                        new Stylist { StylistId = 1, Name = "Jen" },
                        new Stylist { StylistId = 2, Name = "Amy" },
                        new Stylist { StylistId = 3, Name = "Ronda" }
                    );
                }

                if (!context.Clients.Any()) // Checks if there are any Clients
                {
                    context.Clients.AddRange(
                        new Client { ClientId = 1, Name = "Bob", StylistId = 1 },
                        new Client { ClientId = 2, Name = "Juan", StylistId = 2 },
                        new Client { ClientId = 3, Name = "Chan", StylistId = 3 }
                    );
                }
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Logging or handling the exception
                Console.WriteLine(ex.Message);
            }
        }
    }
}
}