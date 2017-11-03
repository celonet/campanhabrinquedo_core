using campanhabrinquedo.domain.Entities.Relationships;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace campanhabrinquedo.repository.Mappings
{
    public class ResponsavelCriancaMap : IEntityTypeConfiguration<ResponsavelCrianca>
    {
        public void Configure(EntityTypeBuilder<ResponsavelCrianca> builder)
        {
            builder
                .HasKey(k => new { k.ResponsavelId, k.CriancaId });
        }
    }
}