namespace campanhabrinquedo.domain.Repositorios.Base
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    
    public interface Search<T> where T : class
    {
         IEnumerable<T> List();
         IEnumerable<T> List(Func<T, bool> expression);
         T FindById(Guid entidadeId);
         T FindByExpression(Func<T, bool> expression);
    }
}