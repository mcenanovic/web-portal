using System.Collections.Generic;
using System.Threading.Tasks;
using WebPortal.Core.ArticleManagement.Entities;

namespace WebPortal.Core.ArticleManagement.Repositories
{
    public interface ICategoryLookupRepository
    {
        Task<CategoryLookup> GetCategoryLookupByIdAsync(int id);

        Task<List<CategoryLookup>> GetCategoryLookupsAsync();

        Task<int> CreateCategoryLookupAsync(CategoryLookup categoryLookup);

        Task UpdateCategoryLookupAsync(CategoryLookup categoryLookup);

        Task DeleteCategoryLookupAsync(int id);

        Task<bool> CategoryLookupExistsAsync(int id);
    }
}
