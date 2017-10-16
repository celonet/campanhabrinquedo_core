using campanhabrinquedo.domain.Entities;

namespace campanhabrinquedo.domain.Interfaces.Actions
{
    public interface IUpdate<in T> where T : EntityBase
    {
        void Update(T entitie);
    }
}