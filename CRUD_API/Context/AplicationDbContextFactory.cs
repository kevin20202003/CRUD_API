using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CRUD_API.Context
{
    public class AplicationDbContextFactory : IDesignTimeDbContextFactory<AplicationDbContext>
    {
        public AplicationDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<AplicationDbContext>();
            var connectionString = configuration.GetConnectionString("CadenaSQL");
            optionsBuilder.UseSqlServer(connectionString);

            return new AplicationDbContext(optionsBuilder.Options);
        }
    }
}
