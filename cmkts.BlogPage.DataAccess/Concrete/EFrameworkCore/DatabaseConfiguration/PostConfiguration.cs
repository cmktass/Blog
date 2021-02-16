using cmkts.BlogPage.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace cmkts.BlogPage.DataAccess.Concrete.EFrameworkCore.DatabaseConfiguration
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Description).IsRequired();

            builder.Property(i => i.PostedDate).IsRequired();

            builder.Property(i => i.Title).IsRequired().HasMaxLength(100);

            builder.HasMany(i => i.Comments).WithOne(i => i.Post).HasForeignKey(i => i.PostId);

            builder.HasMany(i => i.PostCategories).WithOne(i => i.Post).HasForeignKey(i => i.PostId);

            builder.HasMany(i => i.PostTags).WithOne(i => i.Post).HasForeignKey(i => i.PostId);
        }
    }
}
