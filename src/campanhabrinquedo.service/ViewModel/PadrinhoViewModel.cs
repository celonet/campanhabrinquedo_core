using System;

namespace campanhabrinquedo.Application.ViewModel
{
    public class PadrinhoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public ComunidadeViewModel Comunidade { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
    }
}
