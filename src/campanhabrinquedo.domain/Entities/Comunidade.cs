using System;
using System.Collections.Generic;
using campanhabrinquedo.domain.Entities.Relationships;
using campanhabrinquedo.domain.Validators;

namespace campanhabrinquedo.domain.Entities
{
    public class Comunidade : EntityBase
    {
        public string Nome { get; private set; }
        public string Bairro { get; private set; }
        public ICollection<ComunidadeCrianca> Criancas { get; private set; }
        public ICollection<ComunidadePadrinho> Padrinhos { get; private set; }

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

        public override bool IsValid()
        {
            var validationResult = new ComunidadeValidator().Validate(this);
            return validationResult.IsValid;
        }
    }
}