namespace campanhabrinquedo.domain.Entidades
{
    using System;

    public class Usuario
    {
        public Guid UsuarioId { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }

        protected Usuario() { }

        public Usuario(string nome, string email, string senha)
        {
            this.UsuarioId = Guid.NewGuid();
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }

        public Usuario(Guid id, string nome, string email, string senha)
        {
            this.UsuarioId = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }

        public void IncluiDataCadastro()
        {
            this.DataCadastro = DateTime.Now;
        }
    }
}