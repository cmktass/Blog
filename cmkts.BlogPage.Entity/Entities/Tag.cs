using System;
using System.Collections.Generic;
using System.Text;

namespace cmkts.BlogPage.Entity.Entities
{
    public class Tag
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<PostTag> PostTags { get; set; }
    }
}
