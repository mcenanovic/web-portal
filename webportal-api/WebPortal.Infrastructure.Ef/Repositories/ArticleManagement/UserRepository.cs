using System;
using System.Threading.Tasks;
using WebPortal.Core.ArticleManagement.Entities;
using WebPortal.Core.ArticleManagement.Repositories;

namespace WebPortal.Infrastructure.Ef.Repositories
{
    internal class UserRepository : IUserRepository
    {
        public Task<User> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
