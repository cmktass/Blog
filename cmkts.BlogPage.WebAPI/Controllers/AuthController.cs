using AutoMapper;
using cmkts.BlogPage.Entity.Entities;
using cmkts.BlogPage.Service.Interface;
using cmkts.BlogPage.WebAPI.DTO;
using cmkts.BlogPage.WebAPI.JwtTools;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace cmkts.BlogPage.WebAPI.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IMapper mapper;
        private IUserManager userManager;
        private CreateToken createToken;
        public AuthController(IMapper mapper,IUserManager userManager)
        {
            this.mapper = mapper;
            this.userManager = userManager;
            this.createToken = new CreateToken();
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDto user)
        {
            User user1 = new User();
            user1.Email = user.Email;
            user1.Password = user.Password;
            var User=await userManager.CheckUserAsync(user1);
            if (User != null)
            {
                return Ok(createToken.GenerateJwtToken(user1));
            }
            else
            {
                return BadRequest("Kullanıcı Bulunamadı");
            }
        }

        [HttpGet]
        [Authorize]
        public IActionResult ActiveUser()
        {
            UserDto userDto = new UserDto();
            userDto.Name = User.Identity.Name;
            userDto.Surname = User.Identity.Name;
            return Ok(userDto);
        }
    }
}
