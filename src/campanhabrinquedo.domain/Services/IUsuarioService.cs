using System;
using System.Threading.Tasks;
using campanhabrinquedo.domain.Entities;

namespace campanhabrinquedo.domain.Services
{
    public interface IUsuarioService : IServiceActions<Usuario>
    {
        Task<bool> LogarUsuario(string usuario, string senha);
    }
}