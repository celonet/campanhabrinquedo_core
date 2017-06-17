namespace campanhabrinquedo.service.Services
{
    using System;
    using campanhabrinquedo.domain.Entidades;
    using campanhabrinquedo.domain.Services;

    public class UsuarioService : IUsuarioService
    {
        void IUsuarioService.AlteraUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        void IUsuarioService.DeletaUsuario(Guid id)
        {
            throw new NotImplementedException();
        }

        bool IUsuarioService.LogarUsuario(string usuario, string senha)
        {
            throw new NotImplementedException();
        }

        void IUsuarioService.RegistraUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        Usuario IUsuarioService.RetornaPerfil(Guid usuarioId)
        {
            throw new NotImplementedException();
        }
    }
}