using System;
using campanhabrinquedo.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace campanhabrinquedo.repository.Mappings
{
    public class CampanhaMap : IEntityTypeConfiguration<Campanha>
    {
        public void Configure(EntityTypeBuilder<Campanha> builder)
        {
            builder
                .Property(p => p.Descricao)
                .HasMaxLength(200)
                .IsRequired();
            builder
                .Property(p => p.Ano)
                .IsRequired();
        }
    }
}
