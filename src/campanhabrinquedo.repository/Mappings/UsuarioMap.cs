using campanhabrinquedo.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace campanhabrinquedo.repository.Mappings
{
    internal class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder
                .Property(p => p.Nome)
                .HasMaxLength(150)
                .IsRequired();
            builder
                .Property(p => p.Email)
                .HasMaxLength(200)
                .IsRequired();
            builder
                .Property(p => p.Senha)
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}