using cmkts.BlogPage.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace cmkts.BlogPage.DataAccess.Concrete.EFrameworkCore.DatabaseConfiguration
{
    class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Name).IsRequired().HasMaxLength(20);

            builder.HasMany(i => i.IssueCategories).WithOne(i => i.Category).HasForeignKey(i => i.CategoryId);

            builder.HasMany(i => i.PostCategories).WithOne(i => i.Category).HasForeignKey(i => i.CategoryId);


        }
    }
}
