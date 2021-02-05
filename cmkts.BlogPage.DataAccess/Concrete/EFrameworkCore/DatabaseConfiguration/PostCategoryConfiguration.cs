using cmkts.BlogPage.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace cmkts.BlogPage.DataAccess.Concrete.EFrameworkCore.DatabaseConfiguration
{
    class PostCategoryConfiguration : IEntityTypeConfiguration<PostCategory>
    {
        public void Configure(EntityTypeBuilder<PostCategory> builder)
        {
            builder.HasKey(i => new { i.CategoryId, i.PostId });
        }
    }
}
