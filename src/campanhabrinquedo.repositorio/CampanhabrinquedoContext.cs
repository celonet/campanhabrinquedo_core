using Microsoft.EntityFrameworkCore;
using campanhabrinquedo.domain.Entities;

namespace campanhabrinquedo.repositorio
{
    public class CampanhaBrinquedoContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Comunidade> Comunidade { get; set; }
        public DbSet<Crianca> Crianca { get; set; }
        public DbSet<Padrinho> Padrinho { get; set; }
        public DbSet<Responsavel> Responsavel { get; set; }

        public CampanhaBrinquedoContext(DbContextOptions<CampanhaBrinquedoContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Usuario>().HasKey(c => c.UsuarioId);

            modelBuilder.Entity<Comunidade>().ToTable("Comunidade");
            modelBuilder.Entity<Comunidade>().HasKey(c => c.ComunidadeId);

            modelBuilder.Entity<Crianca>().ToTable("Crianca");
            modelBuilder.Entity<Crianca>().HasKey(c => c.CriancaId);

            modelBuilder.Entity<Padrinho>().ToTable("Padrinho");
            modelBuilder.Entity<Padrinho>().HasKey(c => c.PadrinhoId);

            modelBuilder.Entity<Responsavel>().ToTable("Responsavel");
            modelBuilder.Entity<Responsavel>().HasKey(c => c.ResponsavelId);
        }
    }
}