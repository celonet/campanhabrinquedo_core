using System;
using System.Collections.Generic;
using campanhabrinquedo.domain.Entities.Relationships;
using campanhabrinquedo.domain.Validators;
using System.Linq;

namespace campanhabrinquedo.domain.Entities
{
    public class Campanha : EntityBase
    {
        public int Ano { get; private set; }
        public string Descricao { get; private set; }

        public ICollection<CampanhaCrianca> Criancas { get; private set; }
        public ICollection<CampanhaPadrinho> Padrinhos { get; private set; }
        public ICollection<CampanhaResponsavel> Responsaveis { get; private set; }

        protected Campanha() { }

        public Campanha(int ano, string descricao)
        {
            this.Id = Guid.NewGuid();
            this.Ano = ano;
            this.Descricao = descricao;
        }

        public Campanha(Guid id, int ano, string descricao)
        {
            this.Id = id;
            this.Ano = ano;
            this.Descricao = descricao;
        }

        public override bool IsValid()
        {
            var validation = new CampanhaValidator().Validate(this);
            return validation.IsValid;
        }

        public override IList<string> GetErrors()
        {
            var validation = new CampanhaValidator().Validate(this);
            return validation.Errors.Select(e => e.ErrorMessage).ToList();
        }
    }
}