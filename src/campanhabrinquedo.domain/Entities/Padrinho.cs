using campanhabrinquedo.domain.Validators;

using System;
using System.Collections.Generic;
using System.Linq;

namespace campanhabrinquedo.domain.Entities
{    
    public class Padrinho : EntityBase
    {
        public string Nome { get; private set; }
        public Comunidade Comunidade { get; private set; }
        public string Telefone { get; private set; }
        public string Celular { get; private set; }

        public ICollection<PadrinhoCrianca> Criancas { get; private set; }

        protected Padrinho() { }

        public Padrinho(string nome, Comunidade comunidade, string telefone)
        {
            this.Id = Guid.NewGuid();
            this.Nome = nome;
            this.Comunidade = comunidade;
            this.Telefone = telefone;
        }

        public Padrinho(string nome, Comunidade comunidade, string telefone, string celular)
        {
            this.Id = Guid.NewGuid();
            this.Nome = nome;
            this.Comunidade = comunidade;
            this.Telefone = telefone;
            this.Celular = celular;
        }

        public Padrinho(Guid id, string nome, Comunidade comunidade, string telefone, string celular)
        {
            this.Id = id;
            this.Nome = nome;
            this.Comunidade = comunidade;
            this.Telefone = telefone;
            this.Celular = celular;
        }

        public override bool IsValid()
        {
            var validation = new PadrinhoValidator().Validate(this);
            return validation.IsValid;
        }

        public override IList<string> GetErrors()
        {
            var validation = new PadrinhoValidator().Validate(this);
            return validation.Errors.Select(e => e.ErrorMessage).ToList();
        }
    }
}