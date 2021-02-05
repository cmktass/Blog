using System;
using System.Collections.Generic;
using System.Text;

namespace cmkts.BlogPage.Entity.Entities
{
    public class PostTag
    {
        public Post Post { get; set; }

        public int PostId { get; set; }

        public Tag Tag { get; set; }

        public int TagId { get; set; }

        
    }
}
