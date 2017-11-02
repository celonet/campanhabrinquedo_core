using campanhabrinquedo.domain.Entities.Relationships;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace campanhabrinquedo.repository.Mappings
{
    public class ComunidadeCriancaMap : IEntityTypeConfiguration<ComunidadeCrianca>
    {
        public void Configure(EntityTypeBuilder<ComunidadeCrianca> builder)
        {
            builder
                .HasKey(k => new { k.ComunidadeId, k.CriancaId });
        }

    }
}