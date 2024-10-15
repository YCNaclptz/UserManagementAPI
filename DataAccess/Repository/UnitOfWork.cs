using DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly UserDbContext _userDbContext;
        public IUserRepository User { get; set; }

        public UnitOfWork(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
            User = new UserRepository(_userDbContext);

        }

        public async Task<int> SaveAsync()
        {
            return await _userDbContext.SaveChangesAsync();
        }
    }
}
