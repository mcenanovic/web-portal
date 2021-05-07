using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebPortal.Core.ArticleManagement.Entities;
using WebPortal.Core.ArticleManagement.Repositories;

namespace WebPortal.Infrastructure.Ef.Repositories
{
    internal class CommentRepository : ICommentRepository
    {
        private WebPortalDbContext dbContext;

        public CommentRepository(WebPortalDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<bool> CommentExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateCommentAsync(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCommentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> GetCommentByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Comment>> GetCommentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateCommentAsync(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
