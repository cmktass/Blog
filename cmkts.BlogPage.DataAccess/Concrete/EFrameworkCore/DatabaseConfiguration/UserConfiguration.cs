using cmkts.BlogPage.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace cmkts.BlogPage.DataAccess.Concrete.EFrameworkCore.DatabaseConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.BirthDate).IsRequired();

            builder.Property(i => i.Name).IsRequired().HasMaxLength(20);

            builder.Property(i => i.Surname).IsRequired().HasMaxLength(20);

            builder.Property(i => i.Password).IsRequired().HasMaxLength(20);

            builder.Property(i => i.Email).IsRequired().HasMaxLength(40);

            builder.HasMany(i => i.Posts).WithOne(i => i.User).HasForeignKey(i => i.UserId);

            builder.HasMany(i => i.Issues).WithOne(i => i.User).HasForeignKey(i => i.UserId);

            builder.HasMany(i => i.Projects).WithOne(i => i.User).HasForeignKey(i => i.UserId);


        }
    }
}
