using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebPortal.Infrastructure.Ef.Entities;
using WebPortal.Infrastructure.Ef.SeedData;

namespace WebPortal.Infrastructure.Ef.EntityTypeConfiguration
{
    internal class ArticleEntityTypeConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("Articles");

            builder
                .HasKey(x => x.ArticleID);

            builder
                .Property(x => x.Title)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsRequired();

            builder
                .Property(x => x.Description)
                .IsUnicode(false)
                .IsRequired();

            builder
                .Property(x => x.Header)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsRequired();

            builder
                .Property(x => x.ImageURL)
                .HasMaxLength(2048);

            builder
                .Property(x => x.CreatedDateTime)
                .IsRequired();

            builder
                .Property(x => x.UpdatedDateTime)
                .IsRequired();

            builder
                .Property(x => x.SharedCount)
                .HasDefaultValue(0);

            builder
                .HasOne(x => x.User)
                .WithMany(x => x.Articles);

            builder
                .HasOne(x => x.CategoryLookup)
                .WithMany(x => x.Articles);

            builder.SeedData();
        }
    }
}
