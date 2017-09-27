namespace campanhabrinquedo.domain.Actions
{
    using System;
    public interface IDelete<T> where T : Entities.EntitieBase
    {
        void Delete(Guid id);
    }
}