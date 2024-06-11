using CRUD_API.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_API.Context
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Products>().HasIndex(c => c.Name).IsUnique();
        }
    }
}
