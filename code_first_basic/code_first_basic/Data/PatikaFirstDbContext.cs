using code_first_basic.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace code_first_basic.Data
{
    public class PatikaFirstDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=PatikaCodeFirstDb1;Trusted_Connection=True;");
        }
    }
}
