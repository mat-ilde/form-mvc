using MvcProject.Data;
using MvcProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcProject.Models{
     public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcCountryContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcCountryContext>>()))
            {
                // Look for any country.
                if (context.CountryModel.Any())
                {
                    return;   // DB has been seeded
                }

                context.CountryModel.AddRange(
                    new CountryModel
                    {
                        Name = "France",
                        
                    },

                    new CountryModel
                    {
                        Name = "Spain",
                       
                    },

                    new CountryModel
                    {
                        Name = "Dominican Republic",
                       
                    },

                    new CountryModel
                    {
                        Name = "UK",
                        
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
