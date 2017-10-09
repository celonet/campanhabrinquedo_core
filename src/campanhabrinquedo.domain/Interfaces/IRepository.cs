using campanhabrinquedo.domain.Interfaces.Actions;
using campanhabrinquedo.domain.Entities;

namespace campanhabrinquedo.domain.Repositories
{
    public interface IRepository<T> : ICreate<T>, IUpdate<T>, IDelete, ISearch<T> where T : EntitieBase { }
}