using campanhabrinquedo.domain.Entities.Relationships;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace campanhabrinquedo.repository.Mappings
{
    public class CampanhaPadrinhoMap : IEntityTypeConfiguration<CampanhaPadrinho>
    {
        public void Configure(EntityTypeBuilder<CampanhaPadrinho> builder)
        {
            builder
                .HasKey(k => new { k.CampanhaId, k.PadrinhoId });
        }
    }
}