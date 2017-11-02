using campanhabrinquedo.domain.Entities.Relationships;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace campanhabrinquedo.repository.Mappings
{
    public class ComunidadePadrinhoMap : IEntityTypeConfiguration<ComunidadePadrinho>
    {
        public void Configure(EntityTypeBuilder<ComunidadePadrinho> builder)
        {
            builder
                .HasKey(k => new { k.ComunidadeId, k.PadrinhoId});
        }
    }
}