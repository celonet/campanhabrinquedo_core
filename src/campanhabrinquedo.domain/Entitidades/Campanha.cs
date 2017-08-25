namespace campanhabrinquedo.domain.Entidades
{
    using System;

    public class Campanha
    {
        public Guid CampanhaId { get; private set; }
        public int Ano { get; private set; }
        public string Descricao { get; private set; }
        public int QtdeCriancas { get; private set; }

        public Campanha(int ano, string descricao, int qtdeCriancas)
        {            
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