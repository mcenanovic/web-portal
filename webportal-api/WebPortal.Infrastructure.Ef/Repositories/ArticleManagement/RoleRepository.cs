using System;
using System.Threading.Tasks;
using WebPortal.Core.ArticleManagement.Entities;
using WebPortal.Core.ArticleManagement.Repositories;

namespace WebPortal.Infrastructure.Ef.Repositories
{
    internal class RoleRepository : IRoleRepository
    {
        public Task<Role> GetRoleByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
