using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using WebPortal.Core.ArticleManagement.Entities;
using WebPortal.Core.ArticleManagement.Validators;

namespace WebPortal.Core.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static void AddWebPortalCore(this IServiceCollection services)
        {
            services.AddTransient<IValidator<Article>, ArticleValidator>();
            services.AddTransient<IValidator<CategoryLookup>, CategoryLookupValidator>();
            services.AddTransient<IValidator<Comment>, CommentValidator>();
        }
    }
}
