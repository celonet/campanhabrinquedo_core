using System;
using campanhabrinquedo.domain.Entities.Relationships;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace campanhabrinquedo.repository.Mappings
{
    public class CampanhaCriancaMap : IEntityTypeConfiguration<CampanhaCrianca>
    {
        public void Configure(EntityTypeBuilder<CampanhaCrianca> builder)
        {
            builder
                .HasKey(k => new {k.CampanhaId, k.CriancaId});
        }
    }
}
