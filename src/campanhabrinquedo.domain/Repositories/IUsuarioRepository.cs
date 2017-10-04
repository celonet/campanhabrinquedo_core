using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Actions;

namespace campanhabrinquedo.domain.Repositories
{
    public interface IUsuarioRepository : ICreate<Usuario>, IUpdate<Usuario>, IDelete, ISearch<Usuario> { }
}