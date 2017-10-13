namespace campanhabrinquedo.domain.Entities
{
    using System;

    public class Usuario : EntitieBase
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }

        protected Usuario() { }

        public Usuario(string nome, string email, string senha)
        {
            this.Id = Guid.NewGuid();
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }

        public Usuario(Guid id, string nome, string email, string senha)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }
    }
}