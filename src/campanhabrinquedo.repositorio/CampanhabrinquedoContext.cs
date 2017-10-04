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
            modelBuilder.Entity<Campanha>().ToTable("Campanha");
            modelBuilder.Entity<Campanha>().HasKey(c => c.Id);

            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Usuario>().HasKey(c => c.Id);

            modelBuilder.Entity<Comunidade>().ToTable("Comunidade");
            modelBuilder.Entity<Comunidade>().HasKey(c => c.Id);

            modelBuilder.Entity<Crianca>().ToTable("Crianca");
            modelBuilder.Entity<Crianca>().HasKey(c => c.Id);

            modelBuilder.Entity<Padrinho>().ToTable("Padrinho");
            modelBuilder.Entity<Padrinho>().HasKey(c => c.Id);

            modelBuilder.Entity<Responsavel>().ToTable("Responsavel");
            modelBuilder.Entity<Responsavel>().HasKey(c => c.Id);
        }
    }
}