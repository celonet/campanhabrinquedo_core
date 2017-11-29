using campanhabrinquedo.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace campanhabrinquedo.repository.Mappings
{
    internal class CriancaMap : IEntityTypeConfiguration<Crianca>
    {
        public void Configure(EntityTypeBuilder<Crianca> builder)
        {
            builder
                .Property(p => p.Nome)
                .HasMaxLength(150)
                .IsRequired();
            builder
                .Property(p => p.Roupa)
                .HasMaxLength(150)
                .IsRequired();
            builder
                .Property(p => p.Idade)
                .HasMaxLength(150)
                .IsRequired();
        }
    }
}