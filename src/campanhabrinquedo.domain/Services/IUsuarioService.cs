namespace campanhabrinquedo.domain.Services
{
    using System;
    using campanhabrinquedo.domain.Entidades;

    public interface IUsuarioService
    {
        bool LogarUsuario(string usuario, string senha);
        Usuario RetornaPerfil(Guid usuarioId);
        void RegistraUsuario(Usuario usuario);
        void AlteraUsuario(Usuario usuario);
        void DeletaUsuario(Guid id);
        bool UsuarioExiste(Usuario usuario);
    }
}