using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Data.Base
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly LibraryContext context;

        public GenericRepository()
        {
            context = new LibraryContext();
        }

        public async Task<int> Delete(Expression<Func<T, bool>> func)
        {
            var itemsToRemove = await context.Set<T>().Where(func).ToListAsync();

            foreach (var item in itemsToRemove)
            {
                context.Set<T>().Remove(item);
            }

            return await context.SaveChangesAsync();

        }

        public async Task<IList<T>> GetAll()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<IList<T>> GetBy(Expression<Func<T, bool>> func)
        {
            return await context.Set<T>().Where(func).ToListAsync();
        }

        public Task Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Expression<Func<T, bool>> func, T entity)
        {
            throw new NotImplementedException();
        }

        Task IGenericRepository<T>.Update(Expression<Func<T, bool>> func, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
