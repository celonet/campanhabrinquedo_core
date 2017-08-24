namespace campanhabrinquedo.domain.Entidades
{
    using System;
    public class Padrinho
    {
        public Guid PadrinhoId { get; private set; }
        public string Nome { get; set; }
        public Comunidade Comunidade { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
    }
}