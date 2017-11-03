using System;

namespace campanhabrinquedo.domain.Entities.Relationships
{
    public class CampanhaResponsavel
    {
        public Guid CampanhaId { get; set; }
        public Campanha Campanha { get; set; }
        public Guid ResponsavelId { get; set; }
        public Responsavel Responsavel { get; set; }
    }
}