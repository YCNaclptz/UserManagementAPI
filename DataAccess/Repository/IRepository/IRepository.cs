using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(IQueryable<T> query, string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 1000, string? includeProperties = null);
        Task<T?> GetAsync(Expression<Func<T, bool>> filter, string? includeProperties = null);
        Task<T> CreateAsync(T entity);
        Task<T?> DeleteAsync(int id);
    }
}
