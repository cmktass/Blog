using System;
using System.Collections.Generic;
using System.Text;

namespace cmkts.BlogPage.Entity.Entities
{
    public class IssueCategory
    {
        public Issue Issue { get; set; }

        public int IssueId { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }
    }
}
