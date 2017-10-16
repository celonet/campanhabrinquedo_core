using System;

namespace campanhabrinquedo.Application.ViewModel
{
    public class Campanha
    {
        public Guid Id { get; set; }
        public int Ano { get; set; }
        public string Descricao { get; set; }
        public int QtdeCriancas { get; set; }
    }
}
