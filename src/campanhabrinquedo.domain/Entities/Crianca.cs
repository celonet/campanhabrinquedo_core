using System;
using System.Collections.Generic;
using campanhabrinquedo.domain.Validators;
using System.Linq;

namespace campanhabrinquedo.domain.Entities
{
    public class Crianca : EntityBase
    {
        public string Nome { get; private set; }
        public string Idade { get; private set; }
        public string Roupa { get; private set; }
        public string Calcado { get; private set; }
        public Sexo Sexo { get; private set; }
        public Comunidade Comunidade { get; private set; }
        public Responsavel Responsavel { get; private set; }
        public bool Impresso { get; private set; }
        public bool Especial { get; private set; }

        protected Crianca() { }

        public Crianca(string nome, string idade, string roupa, string calcado, Sexo sexo, Comunidade comunidade, Responsavel responsavel)
        {
            this.Id = Guid.NewGuid();
            this.Nome = nome;
            this.Idade = idade;
            this.Roupa = roupa;
            this.Calcado = calcado;
            this.Sexo = sexo;
            this.Comunidade = comunidade;
            this.Responsavel = responsavel;
            this.Impresso = false;
            this.Especial = false;
        }

        public Crianca(string nome, string idade, string roupa, string calcado, Sexo sexo, Comunidade comunidade, Responsavel responsavel, bool impresso, bool especial)
        {
            this.Id = Guid.NewGuid();
            this.Nome = nome;
            this.Idade = idade;
            this.Roupa = roupa;
            this.Calcado = calcado;
            this.Sexo = sexo;
            this.Comunidade = comunidade;
            this.Responsavel = responsavel;
            this.Impresso = impresso;
            this.Especial = especial;
        }

        public Crianca(Guid id, string nome, string idade, string roupa, string calcado, Sexo sexo, Comunidade comunidade, Responsavel responsavel, bool impresso, bool especial)
        {
            this.Id = id;
            this.Nome = nome;
            this.Idade = idade;
            this.Roupa = roupa;
            this.Calcado = calcado;
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

        public override bool IsValid()
        {
            var validation = new CriancaValidator().Validate(this);
            return validation.IsValid;
        }

        public override IList<string> GetErrors()
        {
            var validation = new CriancaValidator().Validate(this);
            return validation.Errors.Select(e => e.ErrorMessage).ToList();
        }
    }
}