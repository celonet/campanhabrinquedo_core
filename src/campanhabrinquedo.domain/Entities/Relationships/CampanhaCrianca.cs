using System;

namespace campanhabrinquedo.domain.Entities.Relationships
{
    public class CampanhaCrianca
    {
        public Guid CampanhaId { get; set; }
        public Campanha Campanha { get; set; }
        public Guid CriancaId { get; set; }
        public Crianca Crianca { get; set; }
    }
}
