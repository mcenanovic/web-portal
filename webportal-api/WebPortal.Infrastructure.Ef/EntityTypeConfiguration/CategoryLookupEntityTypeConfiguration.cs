using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using WebPortal.Infrastructure.Ef.Entities;
using WebPortal.Infrastructure.Ef.SeedData;

namespace WebPortal.Infrastructure.Ef.EntityTypeConfiguration
{
    internal class CategoryLookupEntityTypeConfiguration : IEntityTypeConfiguration<CategoryLookup>
    {
        public void Configure(EntityTypeBuilder<CategoryLookup> builder)
        {
            builder.ToTable("CategoryLookups");

            builder
                .HasKey(x => x.CategoryLookupID);

            builder
                .Property(x => x.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsRequired();

            builder.SeedData();
        }
    }
}
