using cmkts.BlogPage.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace cmkts.BlogPage.DataAccess.Concrete.EFrameworkCore.DatabaseConfiguration
{
    class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Message).IsRequired().HasMaxLength(500);

            builder.Property(i => i.Name).IsRequired();

            builder.Property(i => i.Email).IsRequired();

            builder.Property(i => i.PostedTime).IsRequired();
        }
    }
}
