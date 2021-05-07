using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebPortal.Infrastructure.Ef.Entities;
using WebPortal.Infrastructure.Ef.SeedData;

namespace WebPortal.Infrastructure.Ef.EntityTypeConfiguration
{
    class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder
                .HasKey(x => x.UserID);

            builder
                .Property(x => x.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsRequired();

            builder
                .Property(x => x.LastName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsRequired();

            builder
                .Property(x => x.Email)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.Password)
                .HasMaxLength(200)
                .IsRequired();

            builder
                .HasOne(x => x.Role)
                .WithMany(x => x.Users);

            builder.SeedData();
        }
    }
}
