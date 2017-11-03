using System;

namespace campanhabrinquedo.domain.Entities.Relationships
{
    public class ComunidadeCrianca
    {
        public Guid ComunidadeId { get; set; }
        public Comunidade Comunidade { get; set; }
        public Guid CriancaId { get; set; }
        public Crianca Crianca { get; set; }
    }
}