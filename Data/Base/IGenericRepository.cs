using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Data.Base
{

    public interface IGenericRepository<T> where T : class
    {
        Task Insert(T entity);

        Task Update(Expression<Func<T, bool>> func, T entity);

        Task<int> Delete(Expression<Func<T, bool>> func);

        Task<IList<T>> GetBy(Expression<Func<T, bool>> func);

        Task<IList<T>> GetAll();
    }
}
