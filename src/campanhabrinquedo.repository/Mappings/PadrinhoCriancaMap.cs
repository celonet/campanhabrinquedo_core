using campanhabrinquedo.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace campanhabrinquedo.repository.Mappings
{
    public class PadrinhoCriancaMap : IEntityTypeConfiguration<PadrinhoCrianca>
    {
        public void Configure(EntityTypeBuilder<PadrinhoCrianca> builder)
        {
            builder
                .HasKey(k => new { k.PadrinhoId, k.CriancaId });
        }
    }
}
