using System;
using System.Collections.Generic;
using campanhabrinquedo.domain.Entities.Relationships;
using campanhabrinquedo.domain.Validators;
using System.Linq;

namespace campanhabrinquedo.domain.Entities
{    
    public class Responsavel : EntityBase
    {
        public string Nome { get; private set; }
        public string RG { get; private set; }

        public ICollection<ResponsavelCrianca> Criancas { get; private set; } 

        protected Responsavel() { }

        public Responsavel(string nome, string rg)
        {
            this.Id = Guid.NewGuid();
            this.Nome = nome;
            this.RG = rg;
        }

        public Responsavel(Guid id, string nome, string rg)
        {
            this.Id = id;
            this.Nome = nome;
            this.RG = rg;
        }

        public override bool IsValid()
        {
            var validation = new ResponsavelValidator().Validate(this);
            return validation.IsValid;
        }

        public override IList<string> GetErrors()
        {
            var validation = new ResponsavelValidator().Validate(this);
            return validation.Errors.Select(e => e.ErrorMessage).ToList();
        }
    }
}