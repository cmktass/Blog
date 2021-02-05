using cmkts.BlogPage.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cmkts.BlogPage.DataAccess.Concrete.EFrameworkCore.DatabaseConfiguration
{
    class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.ProjectDescription).IsRequired();

            builder.Property(i => i.ProjectName).IsRequired();

            builder.Property(i => i.ProjectTime).IsRequired();

            builder.Property(i => i.ProjectImages).IsRequired();
        }
    }
}
