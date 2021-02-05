using System;
using System.Collections.Generic;
using System.Text;

namespace cmkts.BlogPage.Entity.Entities
{
    public class Project
    {
        public int Id { get; set; }

        public string ProjectName { get; set; }

        public string ProjectDescription { get; set; }

        public DateTime ProjectTime { get; set; }

        public string ProjectImages { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }

    }
}
