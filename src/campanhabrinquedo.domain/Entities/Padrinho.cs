namespace campanhabrinquedo.domain.Entities
{
    using System;
    public class Padrinho : EntitieBase
    {
        public string Nome { get; private set; }
        public Comunidade Comunidade { get; private set; }
        public string Telefone { get; private set; }
        public string Celular { get; private set; }

        protected Padrinho() { }

        public Padrinho(string nome, Comunidade comunidade, string telefone, string celular)
        {
            this.Id = Guid.NewGuid();
            this.Nome = nome;
            this.Comunidade = comunidade;
            this.Telefone = telefone;
            this.Celular = celular;
        }
    }
}