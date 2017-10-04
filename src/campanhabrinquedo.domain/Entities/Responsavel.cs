using System;

namespace campanhabrinquedo.domain.Entities
{    
    public class Responsavel : EntitieBase
    {
        public string Nome { get; private set; }
        public string RG { get; private set; }

        protected Responsavel() { }

        public Responsavel(string nome, string rg)
        {
            this.Id = Guid.NewGuid();
            this.Nome = nome;
            this.RG = rg;
        }
    }
}