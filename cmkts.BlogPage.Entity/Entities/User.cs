using System;
using System.Collections.Generic;
using System.Text;

namespace cmkts.BlogPage.Entity.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public string ImagePath { get; set; }

        public string Job { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public List<Post> Posts { get; set; }

        public List<Issue> Issues { get; set; }

        public List<Project> Projects { get; set; }

        public string Github { get; set; }

        public string Instagram { get; set; }

        public string Linkedin { get; set; }

        public string Twitter { get; set; }
    }
}
