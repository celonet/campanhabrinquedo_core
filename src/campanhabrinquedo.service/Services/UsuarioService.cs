using System;
using System.Threading.Tasks;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;
using campanhabrinquedo.domain.Services;

namespace campanhabrinquedo.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> LogarUsuario(string login, string senha)
        {
            var usuarioExiste = await _repository.FindByExpressionAsync(usuario => usuario.Email == login && usuario.Senha == senha);
            return usuarioExiste != null;
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