using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPortal.Core.ArticleManagement.Entities;
using WebPortal.Core.ArticleManagement.Models;
using WebPortal.Core.ArticleManagement.Repositories;

namespace WebPortal.Infrastructure.Ef.Repositories
{
    internal class ArticleRepository : IArticleRepository
    {
        private WebPortalDbContext dbContext;

        public ArticleRepository(WebPortalDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<bool> ArticleExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateArticleAsync(Article Article)
        {
            throw new NotImplementedException();
        }

        public Task DeleteArticleAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Article> GetArticleByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ArticleListItem>> GetArticlesAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateArticleAsync(Article Article)
        {
            throw new NotImplementedException();
        }
    }
}
