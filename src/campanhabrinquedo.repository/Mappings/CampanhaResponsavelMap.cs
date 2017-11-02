using campanhabrinquedo.domain.Entities.Relationships;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace campanhabrinquedo.repository.Mappings
{
    public class CampanhaResponsavelMap : IEntityTypeConfiguration<CampanhaResponsavel>
    {
        public void Configure(EntityTypeBuilder<CampanhaResponsavel> builder)
        {
            builder
                .HasKey(k => new { k.CampanhaId, k.ResponsavelId });
        }
    }
}