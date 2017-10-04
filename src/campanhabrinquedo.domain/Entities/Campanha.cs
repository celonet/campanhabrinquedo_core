using System;

namespace campanhabrinquedo.domain.Entities
{
    public class Campanha : EntitieBase
    {
        public int Ano { get; private set; }
        public string Descricao { get; private set; }
        public int QtdeCriancas { get; private set; }

        protected Campanha() { }

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
    }
}