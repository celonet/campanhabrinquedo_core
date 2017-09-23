using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace campanhabrinquedo.repositorio
{
    class CampanhaBrinquedoContextFactory : IDesignTimeDbContextFactory<CampanhaBrinquedoContext>
    {
        public CampanhaBrinquedoContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CampanhaBrinquedoContext>();
            optionsBuilder.UseSqlServer("Server=.;Database=campanhabrinquedo;User=sa;Password=yourStrong(!)Password;", b => b.MigrationsAssembly("campanhabrinquedo.repositorio"));

            return new CampanhaBrinquedoContext(optionsBuilder.Options);
        }
    }
}
