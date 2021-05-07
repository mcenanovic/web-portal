using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebPortal.Core.ArticleManagement.Entities;
using WebPortal.Core.ArticleManagement.Repositories;

namespace WebPortal.Infrastructure.Ef.Repositories
{
    internal class CategoryLookupRepository : ICategoryLookupRepository
    {
        private WebPortalDbContext dbContext;

        public CategoryLookupRepository(WebPortalDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<bool> CategoryLookupExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateCategoryLookupAsync(CategoryLookup categoryLookup)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategoryLookupAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryLookup> GetCategoryLookupByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryLookup>> GetCategoryLookupsAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryLookupAsync(CategoryLookup categoryLookup)
        {
            throw new NotImplementedException();
        }
    }
}
