using System;
using System.Collections.Generic;
using System.Text;

namespace cmkts.BlogPage.Entity.Entities
{   public class Comment
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Message { get; set; }

        public DateTime PostedTime { get; set; }

        public bool IsOk { get; set; }

        public Post Post { get; set; }

        public int PostId { get; set; }
    }
}
