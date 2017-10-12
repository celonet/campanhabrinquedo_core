using System;
using System.Threading.Tasks;
using campanhabrinquedo.domain.Entities;

namespace campanhabrinquedo.domain.Services
{
    public interface IUsuarioService
    {
        Task<bool> LogarUsuario(string usuario, string senha);
        bool UsuarioExiste(Usuario usuario);
        Usuario RetornaPerfil(Guid id);
        void RegistraUsuario(Usuario usuario);
        void AlteraUsuario(Usuario usuario);
        void DeletaUsuario(Guid id);
    }
}