using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyMusic.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        ValueTask<TEntity> GetByIdAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        //find function takes in a delegate expression named predicate, which accepts parameter TEntity and returns boolean.
        //Func Denotes delegate, Expression is linq way of turning it into a expression tree or a search function that linq understands
        //it will use as a definition for search through the entity.
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate); 
        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);    
    }
}
