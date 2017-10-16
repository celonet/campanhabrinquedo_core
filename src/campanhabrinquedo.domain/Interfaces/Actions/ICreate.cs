using campanhabrinquedo.domain.Entities;

namespace campanhabrinquedo.domain.Interfaces.Actions
{
    public interface ICreate<in T> where T : EntityBase
    {
        void Create(T entitie);
    }
}