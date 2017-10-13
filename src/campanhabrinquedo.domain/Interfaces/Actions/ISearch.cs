using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace campanhabrinquedo.domain.Interfaces.Actions
{
    public interface ISearch<T> where T : Entities.EntitieBase
    {
        IQueryable<T> List();
        IQueryable<T> List(Func<T, bool> expression);
         T FindById(Guid id);
         T FindByExpression(Func<T, bool> expression);
        Task<T> FindByExpressionAsync(Expression<Func<T, bool>> expression);
    }
}