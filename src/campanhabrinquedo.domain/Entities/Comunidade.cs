using System;

namespace campanhabrinquedo.domain.Entities
{
    public class Comunidade : EntitieBase
    {
        public string Nome { get; private set; }
        public string Bairro { get; private set; }

        protected Comunidade() { }

        public Comunidade(Guid id, string nome, string bairro)
        {
            this.Id = id;
            this.Nome = nome;
            this.Bairro = bairro;
        }

        public Comunidade(string nome, string bairro)
        {
            this.Id = Guid.NewGuid();
            this.Nome = nome;
            this.Bairro = bairro;
        }
    }
}