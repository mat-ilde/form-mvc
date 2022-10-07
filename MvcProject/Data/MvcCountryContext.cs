using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcProject.Models;

namespace MvcProject.Data{
        public class MvcCountryContext : DbContext
    {
        public MvcCountryContext (DbContextOptions<MvcCountryContext> options)
            : base(options)
        {
        }

        public DbSet<MvcProject.Models.CountryModel> CountryModel { get; set; } = default!;
    }
}


