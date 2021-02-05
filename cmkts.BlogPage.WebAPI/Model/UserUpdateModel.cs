using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cmkts.BlogPage.WebAPI.Model
{
    public class UserUpdateModel
    {
        public int Id { get; set; }
        public IFormFile Image { get; set; }

    }
}
