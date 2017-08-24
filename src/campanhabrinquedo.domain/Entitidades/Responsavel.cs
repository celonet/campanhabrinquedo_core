namespace campanhabrinquedo.domain.Entidades
{
    using System;
    public class Responsavel
    {
        public Guid ResponsavelId { get; private set; }
        public string Nome { get; set; }
        public string RG { get; set; }
    }
}