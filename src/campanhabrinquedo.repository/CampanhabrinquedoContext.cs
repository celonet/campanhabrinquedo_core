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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Campanha>()
                .ToTable("Campanha")
                .HasKey(c => c.Id);

            modelBuilder.Entity<Campanha>()
                .Property(_ => _.DataCadastro).IsRequired();

            modelBuilder.Entity<Usuario>()
                .ToTable("Usuario")
                .HasKey(c => c.Id);

            modelBuilder.Entity<Usuario>()
                .Property(_ => _.DataCadastro).IsRequired();

            modelBuilder.Entity<Comunidade>()
                .ToTable("Comunidade")
                .HasKey(c => c.Id);

            modelBuilder.Entity<Comunidade>()
                .Property(_ => _.DataCadastro).IsRequired();

            modelBuilder.Entity<Crianca>()
                .ToTable("Crianca")
                .HasKey(c => c.Id);

            modelBuilder.Entity<Crianca>()
                .Property(_ => _.DataCadastro).IsRequired();

            modelBuilder.Entity<Padrinho>()
                .ToTable("Padrinho")
                .HasKey(c => c.Id);

            modelBuilder.Entity<Padrinho>()
                .Property(_ => _.DataCadastro).IsRequired();

            modelBuilder.Entity<Responsavel>()
                .ToTable("Responsavel")
                .HasKey(c => c.Id);

            modelBuilder.Entity<Responsavel>()
                .Property(_ => _.DataCadastro).IsRequired();
        }
    }
}