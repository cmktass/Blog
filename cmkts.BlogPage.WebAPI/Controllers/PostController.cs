using cmkts.BlogPage.DataAccess.Interface;
using cmkts.BlogPage.Entity.Entities;
using cmkts.BlogPage.Service.Interface;
using cmkts.BlogPage.WebAPI.DTO.PostDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cmkts.BlogPage.WebAPI.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private IGenericDal<Post> genericDal;
        private IPostManager postManager;

        public PostController(IGenericDal<Post> genericDal, IPostManager postManager)
        {
            this.genericDal = genericDal;
            this.postManager = postManager;
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddNewPost(AddPostDto addPostDto)
        {
            Post post = new Post();
            post.Title = addPostDto.Title;
            post.Description = addPostDto.Description;
            post.UserId = 1;
            post.PostedDate = DateTime.Now;
            post.PostCategories = new List<PostCategory>();
            foreach (var item in addPostDto.CategoryIds)
            {
                PostCategory postCategory = new PostCategory();
                postCategory.CategoryId = item;
                post.PostCategories.Add(postCategory);
            }
            await genericDal.AddAsync(post);

            return Ok();
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> PostSettings()
        {
            var Posts =await postManager.GetAllPostWithCategories();
            List<PostSettingsDto> list = new List<PostSettingsDto>();
            foreach (var item in Posts)
            {
                PostSettingsDto postSettingsDto = new PostSettingsDto();
                postSettingsDto.Id = item.Id;
                postSettingsDto.ClickCount = item.ClickCount;
                postSettingsDto.Title = item.Title;
                postSettingsDto.CategoryName = new List<string>();
                foreach (var item2 in item.PostCategories)
                {
                    postSettingsDto.CategoryName.Add(item2.Category.Name);
                }
                list.Add(postSettingsDto);
            }
            return Ok(list);
        }
    }
}
