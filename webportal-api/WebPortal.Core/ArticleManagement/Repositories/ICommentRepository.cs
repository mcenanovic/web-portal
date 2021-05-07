using System.Collections.Generic;
using System.Threading.Tasks;
using WebPortal.Core.ArticleManagement.Entities;

namespace WebPortal.Core.ArticleManagement.Repositories
{
    public interface ICommentRepository
    {
        Task<Comment> GetCommentByIdAsync(int id);

        Task<List<Comment>> GetCommentsAsync();

        Task<int> CreateCommentAsync(Comment comment);

        Task UpdateCommentAsync(Comment comment);

        Task DeleteCommentAsync(int id);

        Task<bool> CommentExistsAsync(int id);
    }
}
