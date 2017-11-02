using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Entities.Relationships;
using campanhabrinquedo.repository.Mappings;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CampanhaMap());
            modelBuilder.ApplyConfiguration(new ComunidadeMap());
            modelBuilder.ApplyConfiguration(new CriancaMap());
            modelBuilder.ApplyConfiguration(new PadrinhoMap());
            modelBuilder.ApplyConfiguration(new ResponsavelMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());

            //RelationShips
            modelBuilder.ApplyConfiguration(new CampanhaCriancaMap());
            modelBuilder.ApplyConfiguration(new CampanhaPadrinhoMap());
            modelBuilder.ApplyConfiguration(new CampanhaResponsavelMap());
            modelBuilder.ApplyConfiguration(new ComunidadeCriancaMap());
            modelBuilder.ApplyConfiguration(new ComunidadePadrinhoMap());
            modelBuilder.ApplyConfiguration(new ResponsavelCriancaMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFProviders.InMemory;Trusted_Connection=True;");
            }
        }   
    }
}