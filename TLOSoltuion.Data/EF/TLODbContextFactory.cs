using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace TLOSoltuion.Data.EF
{
    public class TLODbContextFactory : IDesignTimeDbContextFactory<TLODbContext>
    {
        public TLODbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("TLODb");

            var optionsBuilder = new DbContextOptionsBuilder<TLODbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new TLODbContext(optionsBuilder.Options);
        }
    }
}
