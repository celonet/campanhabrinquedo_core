namespace campanhabrinquedo.domain.Entidades
{
    using System;
    public class Padrinho
    {
        public Guid PadrinhoId { get; private set; }
        public string Nome { get; private set; }
        public Comunidade Comunidade { get; private set; }
        public string Telefone { get; private set; }
        public string Celular { get; private set; }

        public Padrinho()
        {

        }

        public Padrinho(string nome, Comunidade comunidade, string telefone, string celular)
        {
            this.PadrinhoId = Guid.NewGuid();
            this.Nome = nome;
            this.Comunidade = comunidade;
            this.Telefone = telefone;
            this.Celular = celular;
        }
    }
}