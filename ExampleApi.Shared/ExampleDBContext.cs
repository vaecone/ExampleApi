using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleApi.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ExampleApi.Shared.EF
{
    public class ExampleDBContext : DbContext
    {

        public DbSet<Team> Teams { get; set; } = null;
        public DbSet<Movie> Movies { get; set; } = null;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // change connection string here
            optionsBuilder.UseSqlServer("Server=WKST;Database=test;Trusted_Connection=True;");
        }

    }
}
