using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebPortal.Core.ArticleManagement.Repositories;
using WebPortal.Infrastructure.Ef.Repositories;

namespace WebPortal.Infrastructure.Ef.Extensions.DependencyInjection
{
    public static class DependencyInjectionExtensions
    {
        public static void AddWebPortalInfrastructureEf(this IServiceCollection services, string sqlConnectionString)
        {
            services.AddDbContext<WebPortalDbContext>(opt =>
            {
                opt.UseSqlServer(sqlConnectionString);
            });

            services.AddTransient<IArticleRepository, ArticleRepository>();
            services.AddTransient<ICategoryLookupRepository, CategoryLookupRepository>();
            services.AddTransient<ICommentRepository, CommentRepository>();
            services.AddTransient<IRoleRepository, RoleRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
        }
    }
}
