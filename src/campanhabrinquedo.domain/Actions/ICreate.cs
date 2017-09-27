namespace campanhabrinquedo.domain.Actions
{
    public interface ICreate<T> where T : Entities.EntitieBase
    {
        void Create(T entitie);
    }
}