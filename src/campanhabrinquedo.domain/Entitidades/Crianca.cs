using System;

namespace campanhabrinquedo.domain.Entidades
{
    public class Crianca
    {
        public Guid CriancaId { get; private set; }
        public string Nome { get; set; }
        public string Idade  { get; set; }
        public Sexo Sexo { get; set; }
        public Comunidade Comunidade { get; set; }
        public Responsavel Responsavel { get; set; }
        public bool Impresso{get; private set;}
        public bool Especial {get; private set;}

        public Crianca(string nome, string idade, Sexo sexo, Comunidade comunidade, Responsavel responsavel, bool impresso, bool especial)
        {
            this.CriancaId = Guid.NewGuid();
            this.Nome = nome;
            this.Idade = idade;
            this.Sexo = sexo;
            this.Comunidade = comunidade;
            this.Responsavel = responsavel;
            this.Impresso = impresso;
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