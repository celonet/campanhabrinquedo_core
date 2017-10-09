using campanhabrinquedo.domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace campanhabrinquedo.repository
{
    public class CampanhaBrinquedoContext : DbContext
    {
        public DbSet<Campanha> Campanha { get; set; }
        public DbSet<Comunidade> Comunidade { get; set; }
        public DbSet<Crianca> Crianca { get; set; }
        public DbSet<Padrinho> Padrinho { get; set; }
        public DbSet<Responsavel> Responsavel { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        public CampanhaBrinquedoContext(DbContextOptions options) : base(options) { }
    }
}