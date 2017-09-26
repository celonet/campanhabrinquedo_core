namespace campanhabrinquedo.service.Services
{
    using System;
    using System.Collections.Generic;
    using campanhabrinquedo.domain.Entities;
    using campanhabrinquedo.domain.Repositories;
    using campanhabrinquedo.domain.Services;

    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public void Update(Usuario usuario)
        {
            _repository.Update(usuario);
        }

        public void Delete(Guid entidadeId)
        {
            _repository.Delete(entidadeId);
        }

        public bool LogarUsuario(string login, string senha)
        {
            return _repository.FindByExpression(usuario => usuario.Email == login && usuario.Senha == senha) != null;
        }

        public void Insert(Usuario usuario)
        {
            usuario.IncluiDataCadastro();
            _repository.Create(usuario);
        }

        public Usuario FindById(Guid usuarioId)
        {
            return _repository.FindById(usuarioId);
        }

        public bool UsuarioExiste(Usuario usuario)
        {
            return _repository.FindByExpression(_ => _.Nome == usuario.Nome && _.Email == usuario.Email) != null;
        }

        public IEnumerable<Usuario> List()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> List(Func<Usuario, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Usuario FindByExpression(Func<Usuario, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Usuario RetornaPerfil(Guid id)
        {
            throw new NotImplementedException();
        }

        public void RegistraUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void AlteraUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void DeletaUsuario(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}