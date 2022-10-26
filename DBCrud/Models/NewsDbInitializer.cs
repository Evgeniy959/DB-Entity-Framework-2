using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBCrud.Models
{
    public static class NewsDbInitializer
    {
        public static void Seed(IApplicationBuilder app)
        {
            using var services = app.ApplicationServices.CreateScope();
            var context = services.ServiceProvider.GetRequiredService<BlogDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.Add(new Category { Name = "News" });
                context.Categories.Add(new Category { Name = "Sport" });
                context.Categories.Add(new Category { Name = "Music" });
                context.Categories.Add(new Category { Name = "Games" });
                context.SaveChanges();
            }
        }
    }
}
