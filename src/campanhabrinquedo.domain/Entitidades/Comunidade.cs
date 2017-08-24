using System;

namespace campanhabrinquedo.domain.Entidades
{
    public class Comunidade
    {
        public Guid ComunidadeId { get; private set; }
        public string Nome { get; private set; }
        public string Bairro { get; private set; }

        public Comunidade(string nome, string bairro)
        {
            this.ComunidadeId = Guid.NewGuid();

            if (string.IsNullOrWhiteSpace(nome))
                throw new Exception("Nome não pode ser em branco!");

            if (string.IsNullOrWhiteSpace(bairro))
                throw new Exception("Bairro não pode ser em branco!");

            this.Nome = nome;
            this.Bairro = bairro;
        }
    }
}