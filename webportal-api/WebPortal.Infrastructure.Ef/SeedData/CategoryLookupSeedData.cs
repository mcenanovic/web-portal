using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebPortal.Infrastructure.Ef.Entities;

namespace WebPortal.Infrastructure.Ef.SeedData
{
    internal static class CategoryLookupSeedData
    {
        public static void SeedData(this EntityTypeBuilder<CategoryLookup> builder)
        {
            builder.HasData(
                new CategoryLookup
                {
                    CategoryLookupID = 1,
                    Name = "Trending"
                },
                new CategoryLookup
                {
                    CategoryLookupID = 2,
                    Name = "Politics"
                },
                new CategoryLookup
                {
                    CategoryLookupID = 3,
                    Name = "Business"
                },
                new CategoryLookup
                {
                    CategoryLookupID = 4,
                    Name = "Sports"
                },
                new CategoryLookup
                {
                    CategoryLookupID = 5,
                    Name = "Regional"
                }
            );
        }
    }
}
