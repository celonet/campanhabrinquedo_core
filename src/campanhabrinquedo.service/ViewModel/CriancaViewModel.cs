using System;
using campanhabrinquedo.domain.Entities;

namespace campanhabrinquedo.Application.ViewModel
{
    public class CriancaViewModel : ViewModelBase
    {
        public string Nome { get; set; }
        public string Idade { get; set; }
        public Sexo Sexo { get; set; }
        public ComunidadeViewModel Comunidade { get; set; }
        public ResponsavelViewModel Responsavel { get; set; }
        public bool Impresso { get; set; }
        public bool Especial { get; set; }
        public string Roupa { get; set; }
        public string Calcado { get; set; }
    }
}
