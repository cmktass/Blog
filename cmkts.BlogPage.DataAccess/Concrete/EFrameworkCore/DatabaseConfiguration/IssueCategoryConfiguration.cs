using cmkts.BlogPage.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace cmkts.BlogPage.DataAccess.Concrete.EFrameworkCore.DatabaseConfiguration
{
    class IssueCategoryConfiguration : IEntityTypeConfiguration<IssueCategory>
    {
        public void Configure(EntityTypeBuilder<IssueCategory> builder)
        {
            builder.HasKey(i => new { i.CategoryId, i.IssueId });
        }
    }
}
