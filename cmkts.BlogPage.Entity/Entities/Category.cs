using System;
using System.Collections.Generic;
using System.Text;

namespace cmkts.BlogPage.Entity.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<PostCategory> PostCategories { get; set; }

        public List<IssueCategory> IssueCategories { get; set; }

    }
}
