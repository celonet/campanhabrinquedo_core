using System;

namespace campanhabrinquedo.domain.Entities.Relationships
{
    public class CampanhaPadrinho
    {
        public Guid CampanhaId { get; set; }
        public Campanha Campanha { get; set; }
        public Guid PadrinhoId { get; set; }
        public Padrinho Padrinho { get; set; }
    }
}