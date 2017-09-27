namespace campanhabrinquedo.domain.Actions
{
    public interface IUpdate<T> where T : Entities.EntitieBase
    {
        void Update(T entitie);
    }
}