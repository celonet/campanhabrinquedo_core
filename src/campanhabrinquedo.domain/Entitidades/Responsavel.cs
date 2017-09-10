namespace campanhabrinquedo.domain.Entidades
{
    using System;
    public class Responsavel
    {
        public Guid ResponsavelId { get; private set; }
        public string Nome { get; private set; }
        public string RG { get; private set; }

        protected Responsavel() { }

        public Responsavel(string nome, string rg)
        {
            this.ResponsavelId = Guid.NewGuid();
            this.Nome = nome;
            this.RG = rg;
        }
    }
}