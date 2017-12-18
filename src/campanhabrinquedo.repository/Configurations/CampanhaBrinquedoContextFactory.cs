using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace campanhabrinquedo.repository.Configurations
{
    internal class CampanhaBrinquedoContextFactory : IDesignTimeDbContextFactory<CampanhaBrinquedoContext>
    {
        public CampanhaBrinquedoContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            var connectionString = configuration["ConnectionStrings:DefaultConnection"];
            var optionsBuilder = new DbContextOptionsBuilder<CampanhaBrinquedoContext>();
            optionsBuilder.UseSqlServer(connectionString, b => b.MigrationsAssembly("campanhabrinquedo.repository"));

            return new CampanhaBrinquedoContext(optionsBuilder.Options);
        }
    }
}
