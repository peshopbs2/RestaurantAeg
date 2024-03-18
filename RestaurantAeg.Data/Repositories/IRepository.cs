using RestaurantAeg.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAeg.Data.Repositories
{
    public interface IRepository<T>
        where T : BaseEntity
    {
        public Task<T> AddAsync(T entity);
        public Task<IEnumerable<T>> FilterAsync(Expression<Func<T, bool>> predicate);
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> GetByIdAsync(int id);
        public Task<T> UpdateAsync(T entity);
        public Task DeleteByIdAsync(int id);
    }
}
