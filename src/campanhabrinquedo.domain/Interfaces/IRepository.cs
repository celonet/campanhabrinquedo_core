using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Interfaces.Actions;

namespace campanhabrinquedo.domain.Interfaces
{
    public interface IRepository<T> : ICreate<T>, IUpdate<T>, IDelete, ISearch<T> where T : EntityBase { }
}