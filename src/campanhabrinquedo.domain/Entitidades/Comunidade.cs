using System;

namespace campanhabrinquedo.domain.Entidades
{
    public class Comunidade
    {
        public Guid ComunidadeId { get; private set; }
        public string Nome { get; private set; }
        public string Bairro { get; private set; }

        protected Comunidade() { }

        public Comunidade(string nome, string bairro)
        {
            this.ComunidadeId = Guid.NewGuid();
            this.Nome = nome;
            this.Bairro = bairro;
        }
    }
}