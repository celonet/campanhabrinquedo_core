using System;

namespace campanhabrinquedo.domain.Entities
{    
    public class Usuario
    {
        public Guid UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }    
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}