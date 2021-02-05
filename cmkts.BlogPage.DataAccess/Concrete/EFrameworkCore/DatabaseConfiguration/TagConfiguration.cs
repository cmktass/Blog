using cmkts.BlogPage.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace cmkts.BlogPage.DataAccess.Concrete.EFrameworkCore.DatabaseConfiguration
{
    class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Name).IsRequired().HasMaxLength(20);

            builder.HasMany(i => i.PostTags).WithOne(i => i.Tag).HasForeignKey(i => i.TagId);
        }
    }
}
