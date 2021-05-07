using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebPortal.Infrastructure.Ef.Entities;

namespace WebPortal.Infrastructure.Ef.SeedData
{
    internal static class RoleSeedData
    {
        public static void SeedData(this EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
                new Role
                {
                    RoleID = 1,
                    Name = "Admin"
                },
                new Role
                {
                    RoleID = 2,
                    Name = "Writer"
                },
                new Role
                {
                    RoleID = 3,
                    Name = "Visitor"
                }
            );
        }
    }
}
