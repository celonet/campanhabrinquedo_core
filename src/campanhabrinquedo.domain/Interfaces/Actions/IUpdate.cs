namespace campanhabrinquedo.domain.Interfaces.Actions
{
    public interface IUpdate<in T> where T : Entities.EntitieBase
    {
        void Update(T entitie);
    }
}