using Model.Domain;
using Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface IUserRepository: IRepository<User>
    {
        IQueryable<User> GetQueryOnFilter(string? name, int? minAge, int? maxAge, int? gender);
        Task<IEnumerable<User>?> GetUsers(string? name, int? minAge, int? max, int? gender, string? sortBy, bool isAscending, int pageNumber = 1, int pageSize = 10, string? includeProperties = null);
        Task<User?> Update(int id, User user);
        Task<IEnumerable<UserSummaryDto>> GetUserSummary();
    }
}
