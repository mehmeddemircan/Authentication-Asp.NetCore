using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IBaseRepository<T> where T : class, IEntity, new()
    {

        Task<T> AddAsync(T entity);

        Task<List<T>> GetAllAsync();

        Task UpdateAsync(int id, T entity);

        Task<T> GetById(int id);

        T Get(Expression<Func<T, bool>> filter);


        Task DeleteAsync(int id);
    }
}
