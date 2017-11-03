using System;

namespace campanhabrinquedo.domain.Entities.Relationships
{
    public class ResponsavelCrianca 
    {
        public Guid ResponsavelId { get; set; }
        public Responsavel Responsavel { get; set; }
        public Guid CriancaId { get; set; }
        public Crianca Crianca { get; set; }
    }
}