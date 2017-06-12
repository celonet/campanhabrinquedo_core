using System;

namespace campanhabrinquedo.domain.Entities
{
    public class Padrinho
    {
        public Guid PadrinhoId { get; set; }
        public string Nome { get; set; }
        public Comunidade Comunidade  { get; set; }
        public string Telefone { get; set; }
        public string Celular  { get; set; }
    }
}