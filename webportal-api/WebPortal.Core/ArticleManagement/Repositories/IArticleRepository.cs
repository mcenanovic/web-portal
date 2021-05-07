using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebPortal.Core.ArticleManagement.Entities;
using WebPortal.Core.ArticleManagement.Models;

namespace WebPortal.Core.ArticleManagement.Repositories
{
    public interface IArticleRepository
    {
        Task<Article> GetArticleByIdAsync(int id);

        Task<List<ArticleListItem>> GetArticlesAsync();

        Task<int> CreateArticleAsync(Article article);

        Task UpdateArticleAsync(Article article);

        Task DeleteArticleAsync(int id);

        Task<bool> ArticleExistsAsync(int id);
    }
}
