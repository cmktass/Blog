using System;
using System.Collections.Generic;
using System.Text;

namespace cmkts.BlogPage.Entity.Entities
{
    public class Issue
    {
        public int Id { get; set; }

        public string IssueName { get; set; }

        public DateTime IssueDate { get; set; }

        public string IssueDescription { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }

        public List<IssueCategory> IssueCategories { get; set; }

        public bool IsSuccess { get; set; }
    }
}
