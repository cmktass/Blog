using AutoMapper;
using cmkts.BlogPage.Entity.Entities;
using cmkts.BlogPage.Service.Interface;
using cmkts.BlogPage.WebAPI.DTO;
using cmkts.BlogPage.WebAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace cmkts.BlogPage.WebAPI.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class UserInfoController : FileController
    {
        private IMapper mapper;
        private IUserManager userManager;

        public UserInfoController(IMapper mapper,IUserManager userManager)
        {
            this.mapper = mapper;
            this.userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> UserInfos()
        {
            var user = mapper.Map<UserInfoDto>(await userManager.GetByIdAsync(1));
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUserInfo([FromForm]UserUpdateModel userUpdateModel)
        {
            var uploadModel = await UploadImages(userUpdateModel.Image, "image/jpeg");
            
            if (uploadModel.UploadState == Enums.UploadState.Success)
            {
                var user=await userManager.GetByIdAsync(userUpdateModel.Id);
                user.ImagePath = uploadModel.NewName;
                await userManager.UpdateAsync(user);
                return NoContent();
            }
            else if(uploadModel.UploadState==Enums.UploadState.NotExist)
            {
                return BadRequest(uploadModel.ErrorMessage);
            }
            else
            {
                return BadRequest(uploadModel.ErrorMessage);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> UserImageAsync(int id)
        {
           var user = await userManager.GetByIdAsync(id);
            
            if (!string.IsNullOrEmpty(user.ImagePath))
            {
               return File($"/{user.ImagePath}","image/jpeg");
            }
            else
            {
                return BadRequest("");
            }
        }
    }
}
