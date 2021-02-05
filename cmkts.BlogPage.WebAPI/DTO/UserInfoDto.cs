
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cmkts.BlogPage.WebAPI.DTO
{
    public class UserInfoDto
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public string ImagePath { get; set; }

        public string Job { get; set; }

        public string Email { get; set; }

        public string Github { get; set; }

        public string Instagram { get; set; }

        public string Linkedin { get; set; }

        public string Twitter { get; set; }
    }
}
