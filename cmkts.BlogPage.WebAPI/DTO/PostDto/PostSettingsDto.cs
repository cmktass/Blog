using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cmkts.BlogPage.WebAPI.DTO.PostDto
{
    public class PostSettingsDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime PostedDate { get; set; }

        public int ClickCount { get; set; }

        public List<string> CategoryName { get; set; }
    }
}
