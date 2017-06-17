using System;

namespace campanhabrinquedo.domain.Entidades
{
    public class Comunidade
    {
        public Guid ComunidadeId { get; set; }
        public string Nome { get; set; }
        public string Bairro { get; set; }

        public Comunidade()
        {
            this.ComunidadeId = Guid.NewGuid();
        }
    }
}