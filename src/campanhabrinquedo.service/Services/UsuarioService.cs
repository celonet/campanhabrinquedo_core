namespace campanhabrinquedo.service.Services
{
    using System;
    using campanhabrinquedo.domain.Entidades;
    using campanhabrinquedo.domain.Repositorios;
    using campanhabrinquedo.domain.Services;

    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepositorio _repositorio;

        public UsuarioService(IUsuarioRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        void IUsuarioService.AlteraUsuario(Usuario usuario)
        {
            _repositorio.Update(usuario);
        }

        void IUsuarioService.DeletaUsuario(Guid id)
        {
            _repositorio.Delete(id);
        }

        bool IUsuarioService.LogarUsuario(string usuario, string senha)
        {
            return _repositorio.FindByExpression(_ => _.Email == usuario && _.Senha == senha) != null;
        }

        void IUsuarioService.RegistraUsuario(Usuario usuario)
        {
            usuario.IncluiDataCadastro();
            _repositorio.Insert(usuario);
        }

        Usuario IUsuarioService.RetornaPerfil(Guid usuarioId)
        {
            return _repositorio.FindById(usuarioId);
        }

        bool IUsuarioService.UsuarioExiste(Usuario usuario)
        {
            return _repositorio.FindByExpression(_ => _.Nome == usuario.Nome && _.Email == usuario.Email) != null;
        }
    }
}