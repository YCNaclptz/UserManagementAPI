using DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using Model.Domain;
using Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class UserRepository : SQLRepository<User>, IUserRepository
    {
        private readonly UserDbContext _userDbContext;

        public UserRepository(UserDbContext userDbContext) : base(userDbContext)
        {
            _userDbContext = userDbContext;
        }

        public IQueryable<User> GetQueryOnFilter(string? name, int? minAge, int? maxAge, int? gender)
        {
            var query = _userDbContext.Users.AsQueryable();
            if (!string.IsNullOrWhiteSpace(name))
            {
                query = query.Where(user => user.Name.Contains(name));
            }
            if (minAge.HasValue)
            {
                query = query.Where(user => user.Age >= minAge);
            }
            if (maxAge.HasValue)
            {
                query = query.Where(user => user.Age <= maxAge);
            }
            if (gender.HasValue) {
                query = query.Where(user => user.Gender == (Gender)gender);
            }
            return query;
        }

        public async Task<IEnumerable<User>?> GetUsers(string? name, int? minAge, int? max, int? gender, string? sortBy, bool isAscending, int pageNumber = 1, int pageSize = 10, string? includeProperties = null) {

            var query = GetQueryOnFilter(name, minAge, max, gender);
            return await GetAllAsync(query, sortBy, isAscending, pageNumber, pageSize, includeProperties);
        }

        public async Task<User?> Update(int id, User user)
        {
            var existingUser = await _userDbContext.Users.FindAsync(id);
            if (existingUser is null)
            {
                return null;
            }
            existingUser.Email = user.Email;
            existingUser.Password = user.Password;
            existingUser.Name = user.Name;
            existingUser.Age = user.Age;
            existingUser.Gender = user.Gender;

            return existingUser;
        }

        public async Task<IEnumerable<UserSummaryDto>> GetUserSummary()
        {
            return await _userDbContext.Users
                .GroupBy(u => new { u.City, u.Gender })
                .Select(g => new UserSummaryDto
                {
                    City = g.Key.City,
                    Gender = g.Key.Gender == Gender.Male ? "男" : "女",
                    TotalCount = g.Count()
                })
                .ToListAsync();
        }
    }
}
