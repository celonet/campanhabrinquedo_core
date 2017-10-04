using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Actions;

namespace campanhabrinquedo.domain.Repositories
{
    public interface IComunidadeRepository : ICreate<Comunidade>, IUpdate<Comunidade>, IDelete, ISearch<Comunidade> { }
}