using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cmkts.BlogPage.WebAPI.DTO.TagDto
{
    public class AddTagDto
    {
        [Required(ErrorMessage ="Bos Gecilemez")]
        public string Name { get; set; }
    }
}
