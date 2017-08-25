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
            if (!ValidaAno(ano))
                throw new Exception("Ano não pode ser menor que o primeiro ano da campanha ou maior que o ano vigente!");

            if (string.IsNullOrWhiteSpace(descricao))
                throw new Exception("Descrição não pode ser em branco!");

            this.Ano = ano;
            this.Descricao = descricao;
            this.QtdeCriancas = qtdeCriancas;
        }

        public void IncrementaQuantidadeCriancas()
        {
            this.QtdeCriancas++;
        }

        private bool ValidaAno(int ano)
        {
            return ano > 2005 && ano < DateTime.Now.AddYears(1).Year;
        }
    }
}