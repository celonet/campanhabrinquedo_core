using System;

namespace campanhabrinquedo.domain.Entities
{
    public class PadrinhoCrianca
    {
        public Guid PadrinhoId { get; set; }
        public Padrinho Responsavel { get; set; }
        public Guid CriancaId { get; set; }
        public Crianca Crianca { get; set; }
    }
}