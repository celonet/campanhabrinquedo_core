using campanhabrinquedo.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace campanhabrinquedo.repository.Mappings
{
    internal class ResponsavelMap : IEntityTypeConfiguration<Responsavel>
    {
        public void Configure(EntityTypeBuilder<Responsavel> builder)
        {
            builder
                .Property(p => p.Nome)
                .HasMaxLength(150)
                .IsRequired();
            builder
                .Property(p => p.RG)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}