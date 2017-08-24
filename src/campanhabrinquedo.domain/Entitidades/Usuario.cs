namespace campanhabrinquedo.domain.Entidades
{
    using System;
    using System.Text.RegularExpressions;

    public class Usuario
    {
        public Guid UsuarioId { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public Usuario(string nome, string email, string senha)
        {
            if (!NomeEValido(nome))
                throw new Exception("Nome é inválido");

            if (!EmailEValido(email))
                throw new Exception("Email inválido");

            if (!SenhaEValida(senha))
                throw new Exception("Senha inválida");

            this.UsuarioId = Guid.NewGuid();
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }

        public Usuario(Guid id, string nome, string email, string senha)
        {
            if (!NomeEValido(nome))
                throw new Exception("Nome é inválido");

            if (!EmailEValido(email))
                throw new Exception("Email inválido");

            if (!SenhaEValida(senha))
                throw new Exception("Senha inválida");

            this.UsuarioId = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }

        private bool EmailEValido(string email)
        {
            return !string.IsNullOrWhiteSpace(email) && new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Match(email).Success;
        }

        private bool SenhaEValida(string senha)
        {
            return !string.IsNullOrWhiteSpace(senha) && senha.Length >= 6;
        }
        private bool NomeEValido(string nome)
        {
            return !string.IsNullOrWhiteSpace(nome) && nome.Length > 3;
        }

        public void IncluiDataCadastro()
        {
            this.DataCadastro = DateTime.Now;
        }
    }
}