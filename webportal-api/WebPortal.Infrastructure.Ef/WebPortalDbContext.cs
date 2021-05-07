using Microsoft.EntityFrameworkCore;
using WebPortal.Infrastructure.Ef.Entities;
using WebPortal.Infrastructure.Ef.EntityTypeConfiguration;

namespace WebPortal.Infrastructure.Ef
{
    internal class WebPortalDbContext : DbContext
    {
        public WebPortalDbContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions) 
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<CategoryLookup> CategoryLookups { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ArticleEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryLookupEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CommentEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RoleEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());
        }
    }
}
