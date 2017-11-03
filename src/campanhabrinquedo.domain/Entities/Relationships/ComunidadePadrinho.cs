using System;

namespace campanhabrinquedo.domain.Entities.Relationships
{
    public class ComunidadePadrinho
    {
        public Guid ComunidadeId { get; set; }
        public Comunidade Comunidade { get; set; }
        public Guid PadrinhoId { get; set; }
        public Padrinho Padrinho { get; set; }
    }
}