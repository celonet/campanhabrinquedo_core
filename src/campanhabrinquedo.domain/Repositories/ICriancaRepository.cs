using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Actions;

namespace campanhabrinquedo.domain.Repositories
{
    public interface ICriancaRepository : ICreate<Crianca>, IUpdate<Crianca>, IDelete, ISearch<Crianca> { }
}