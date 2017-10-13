using System;
using campanhabrinquedo.domain.Validators;

namespace campanhabrinquedo.domain.Entities
{
    public class Campanha : EntityBase
    {
        public int Ano { get; private set; }
        public string Descricao { get; private set; }
        public int QtdeCriancas { get; private set; }

        protected Campanha() { }

        public Campanha(int ano, string descricao)
        {
            this.Id = Guid.NewGuid();
            this.Ano = ano;
            this.Descricao = descricao;
            this.QtdeCriancas = 0;
        }

        public Campanha(int ano, string descricao, int qtdeCriancas)
        {
            this.Id = Guid.NewGuid();
            this.Ano = ano;
            this.Descricao = descricao;
            this.QtdeCriancas = qtdeCriancas;
        }

        public void IncrementaQuantidadeCriancas()
        {
            this.QtdeCriancas++;
        }

        public override bool IsValid()
        {
            var validation = new CampanhaValidator().Validate(this);
            return validation.IsValid;
        }
    }
}