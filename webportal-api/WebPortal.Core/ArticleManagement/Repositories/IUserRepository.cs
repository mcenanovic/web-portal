using System.Threading.Tasks;
using WebPortal.Core.ArticleManagement.Entities;

namespace WebPortal.Core.ArticleManagement.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUserByIdAsync(int id);
    }
}
