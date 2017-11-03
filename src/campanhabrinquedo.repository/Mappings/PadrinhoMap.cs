using campanhabrinquedo.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace campanhabrinquedo.repository.Mappings
{
    internal class PadrinhoMap : IEntityTypeConfiguration<Padrinho>
    {
        public void Configure(EntityTypeBuilder<Padrinho> builder)
        {
            builder
                .Property(p => p.Nome)
                .HasMaxLength(150)
                .IsRequired();
            builder
                .Property(p => p.Telefone)
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}