using survivor.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace survivor.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Competitor> Competitors { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
