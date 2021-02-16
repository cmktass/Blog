using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cmkts.BlogPage.WebAPI.DTO.PostDto
{
    public class AddPostDto
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int[] CategoryIds { get; set; }
    }
}
