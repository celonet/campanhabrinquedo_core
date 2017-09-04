using System;

namespace campanhabrinquedo.domain.Entidades
{
    public class Crianca
    {
        public Guid CriancaId { get; private set; }
        public string Nome { get; private set; }
        public string Idade { get; private set; }
        public Sexo Sexo { get; private set; }
        public Comunidade Comunidade { get; private set; }
        public Responsavel Responsavel { get; private set; }
        public bool Impresso { get; private set; }
        public bool Especial { get; private set; }

        public Crianca()
        {

        }

        public Crianca(string nome, string idade, Sexo sexo, Comunidade comunidade, Responsavel responsavel, bool Impresso, bool especial)
        {
            this.CriancaId = Guid.NewGuid();
            this.Nome = nome;
            this.Idade = idade;
            this.Sexo = sexo;
            this.Comunidade = comunidade;
            this.Responsavel = responsavel;
            this.Impresso = Impresso;
            this.Especial = especial;
        }

        public void Imprimir()
        {
            this.Impresso = true;
        }

        public void EhEspecial()
        {
            this.Especial = true;
        }
    }
}