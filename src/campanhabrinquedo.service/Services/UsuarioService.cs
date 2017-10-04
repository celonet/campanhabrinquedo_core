namespace campanhabrinquedo.service.Services
{
    using System;
    using domain.Entities;
    using domain.Repositories;
    using domain.Services;

    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public bool LogarUsuario(string login, string senha)
        {
            return _repository.FindByExpression(usuario => usuario.Email == login && usuario.Senha == senha) != null;
        }

        public bool UsuarioExiste(Usuario usuario)
        {
            return _repository.FindByExpression(_ => _.Nome == usuario.Nome && _.Email == usuario.Email) != null;
        }

        public Usuario RetornaPerfil(Guid usuarioId)
        {
            return _repository.FindById(usuarioId);
        }

        public void RegistraUsuario(Usuario usuario)
        {
            usuario.IncluiDataCadastro();
            _repository.Create(usuario);
        }

        public void AlteraUsuario(Usuario usuario)
        {
            _repository.Update(usuario);
        }

        public void DeletaUsuario(Guid usuarioId)
        {
            _repository.Delete(usuarioId);
        }
    }
}