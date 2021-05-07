using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebPortal.Infrastructure.Ef.Entities;
using WebPortal.Infrastructure.Ef.SeedData;

namespace WebPortal.Infrastructure.Ef.EntityTypeConfiguration
{
    class RoleEntityTypeConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles");

            builder
                .HasKey(x => x.RoleID);

            builder
                .Property(x => x.Name)
                .HasMaxLength(30)
                .IsRequired();

            builder.SeedData();
        }
    }
}
