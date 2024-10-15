using DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class SQLRepository<T> : IRepository<T> where T : class
    {
        private readonly UserDbContext _dbContext;
        public SQLRepository(UserDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> CreateAsync(T entity)
        {
            await _dbContext.AddAsync(entity);
            return entity;
        }

        public async Task<T?> DeleteAsync(int id)
        {
            var existingEntity = await _dbContext.FindAsync<T>(id);
            if (existingEntity is null)
            {
                return null;
            }
            _dbContext.Remove(existingEntity);
            return existingEntity;
        }

        public async Task<IEnumerable<T>> GetAllAsync(IQueryable<T> query, string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 1000, string? includeProperties = null)
        {

            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (string includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(prop => prop.Trim()))
                {
                    query = query.Include(includeProp);
                }
            }
            // Sorting
            if (!string.IsNullOrWhiteSpace(sortBy))
            {

                Type entityType = typeof(T);
                PropertyInfo? filterProperty = entityType.GetProperty(sortBy, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                if (filterProperty is not null)
                {
                    query = isAscending ? query.OrderBy(entity => EF.Property<object>(entity, filterProperty.Name)) : query.OrderByDescending(entity => EF.Property<object>(entity, filterProperty.Name));
                }
            }
            // Pagination
            if (pageNumber > 0)
            {
                query = query.Skip((pageNumber - 1) * pageSize).Take(pageSize);
            }
            

            return await query.ToListAsync();
        }


        public async Task<T?> GetAsync(Expression<Func<T, bool>> filter, string? includeProperties = null)
        {
            IQueryable<T> query = _dbContext.Set<T>();
            query = query.Where(filter);
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (string includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(prop => prop.Trim()))
                {
                    query = query.Include(includeProp);
                }
            }
            return await query.FirstOrDefaultAsync();
        }
    }
}
