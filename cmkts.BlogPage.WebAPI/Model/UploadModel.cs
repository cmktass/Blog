using cmkts.BlogPage.WebAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cmkts.BlogPage.WebAPI.Model
{
    public class UploadModel
    {
        public string NewName { get; set; }

        public UploadState UploadState { get; set; }

        public string ErrorMessage { get; set; }
    }
}
