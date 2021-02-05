using System;
using System.Collections.Generic;
using System.Text;

namespace cmkts.BlogPage.Entity.Entities
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime PostedDate { get; set; }

        public string ImageAddres { get; set; }

        public int ClickCount{ get; set; }

        public User User { get; set; }

        public int UserId { get; set; }

        public List<Comment> Comments { get; set; }

        public List<PostTag> PostTags { get; set; }

        public List<PostCategory> PostCategories { get; set; }
    }
}
