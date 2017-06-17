namespace campanhabrinquedo.domain.Entidades
{
    using System;
    using System.Text.RegularExpressions;

    public class Usuario
    {
        public Guid UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        public Usuario()
        {

        }
        public Usuario(string nome, string email, string senha)
        {
            if (!NomeEValido(nome))
                throw new Exception("Nome é inválido");

            if (!EmailEValido(email))
                throw new Exception("Emai");

            if (!SenhaEValida(senha))
                throw new Exception("Senha inválida");

            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }

        public bool EmailEValido(string email)
        {
            return string.IsNullOrWhiteSpace(email) && new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Match(email).Success;
        }

        public bool SenhaEValida(string senha)
        {
            return !string.IsNullOrWhiteSpace(senha) && senha.Length >= 6;
        }

        public bool NomeEValido(string nome)
        {
            return !string.IsNullOrWhiteSpace(nome) && nome.Length > 3;
        }
    }
}