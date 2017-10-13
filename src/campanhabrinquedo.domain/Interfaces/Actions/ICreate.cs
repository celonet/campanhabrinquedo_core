namespace campanhabrinquedo.domain.Interfaces.Actions
{
    public interface ICreate<in T> where T : Entities.EntitieBase
    {
        void Create(T entitie);
    }
}