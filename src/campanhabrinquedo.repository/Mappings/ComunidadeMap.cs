using campanhabrinquedo.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace campanhabrinquedo.repository.Mappings
{
    internal class ComunidadeMap : IEntityTypeConfiguration<Comunidade>
    {
        public void Configure(EntityTypeBuilder<Comunidade> builder)
        {
            builder
                .Property(p => p.Bairro)
                .HasMaxLength(150)
                .IsRequired();

            builder
                .Property(p => p.Nome)
                .HasMaxLength(150)
                .IsRequired();
        }
    }
}