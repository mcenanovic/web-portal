using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebPortal.Infrastructure.Ef.Entities;

namespace WebPortal.Infrastructure.Ef.SeedData
{
    internal static class UserSeedData
    {
        public static void SeedData(this EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    UserID = 1,
                    FirstName = "Admin",
                    LastName = "Admin",
                    Email = "admin@admin.com",
                    Password = "pw",
                    Role = new Role
                    {
                        RoleID = 1,
                        Name = "Admin"
                    }
                }
            );
        }
    }
}
