using System.Threading.Tasks;
using WebPortal.Core.ArticleManagement.Entities;

namespace WebPortal.Core.ArticleManagement.Repositories
{
    public interface IRoleRepository
    {
        Task<Role> GetRoleByIdAsync(int id);
    }
}
