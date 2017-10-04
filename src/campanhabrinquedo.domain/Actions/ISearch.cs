namespace campanhabrinquedo.domain.Actions
{
    using System;
    using System.Collections.Generic;

    public interface ISearch<out T> where T : Entities.EntitieBase
    {
         IEnumerable<T> List();
         IEnumerable<T> List(Func<T, bool> expression);
         T FindById(Guid id);
         T FindByExpression(Func<T, bool> expression);
    }
}