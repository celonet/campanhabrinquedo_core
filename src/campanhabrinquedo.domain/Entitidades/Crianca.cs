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