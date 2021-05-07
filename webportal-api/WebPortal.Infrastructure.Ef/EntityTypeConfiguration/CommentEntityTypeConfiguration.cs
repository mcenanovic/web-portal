using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebPortal.Infrastructure.Ef.Entities;
using WebPortal.Infrastructure.Ef.SeedData;

namespace WebPortal.Infrastructure.Ef.EntityTypeConfiguration
{
    class CommentEntityTypeConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");

            builder
                .HasKey(x => x.CommentID);

            builder
                .Property(x => x.Description)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .IsRequired();

            builder
                .Property(x => x.CreatedDateTime)
                .IsRequired();

            builder
                .Property(x => x.UpVote)
                .HasDefaultValue(0);

            builder
                .Property(x => x.DownVote)
                .HasDefaultValue(0);

            builder
                .HasOne(x => x.ReplyComment)
                .WithOne();

            builder
                .HasOne(x => x.Article)
                .WithMany(x => x.Comments)
                .IsRequired();

            builder
                .HasOne(x => x.User)
                .WithMany(x => x.Comments)
                .IsRequired();

            builder.SeedData();
        }
    }
}
