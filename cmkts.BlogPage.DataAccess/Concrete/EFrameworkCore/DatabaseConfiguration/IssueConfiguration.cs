using cmkts.BlogPage.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace cmkts.BlogPage.DataAccess.Concrete.EFrameworkCore.DatabaseConfiguration
{
    class IssueConfiguration : IEntityTypeConfiguration<Issue>
    {
        public void Configure(EntityTypeBuilder<Issue> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.IssueDate).IsRequired();

            builder.Property(i => i.IssueDescription).IsRequired();

            builder.Property(i => i.IssueName).IsRequired();

            builder.HasMany(i => i.IssueCategories).WithOne(i => i.Issue).HasForeignKey(i => i.IssueId);


        }
    }
}
