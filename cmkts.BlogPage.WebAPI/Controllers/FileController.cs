using cmkts.BlogPage.WebAPI.Enums;
using cmkts.BlogPage.WebAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace cmkts.BlogPage.WebAPI.Controllers
{
    
    public class FileController : ControllerBase
    {
        [HttpPut]
        public async Task<UploadModel> UploadImages(IFormFile file,string contentType)
        {
            UploadModel uploadModel = new UploadModel();
            if (file != null)
            {
                if (file.ContentType != contentType)
                {
                    uploadModel.ErrorMessage = "Dosya türü hatalı";
                    uploadModel.UploadState = UploadState.Error;
                    return uploadModel;
                }
                else
                {
                    var newName = Guid.NewGuid() + Path.GetExtension(file.FileName);
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/" + newName);
                    var stream = new FileStream(path, FileMode.Create);
                    await file.CopyToAsync(stream);
                    uploadModel.UploadState = UploadState.Success;
                    uploadModel.NewName = newName;
                    return uploadModel;
                }
            }
            uploadModel.ErrorMessage = "Dosya Bulunamadı";
            uploadModel.UploadState = UploadState.NotExist;
            return uploadModel;
        }
    }
}
