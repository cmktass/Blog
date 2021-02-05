using System;
using System.Collections.Generic;
using System.Text;

namespace cmkts.BlogPage.Entity.Entities
{
    public class PostCategory
    {
        public Post Post { get; set; }

        public int PostId { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }
    }
}
