using AutoMapper;
using cmkts.BlogPage.Entity.Entities;
using cmkts.BlogPage.Service.Interface;
using cmkts.BlogPage.WebAPI.DTO.TagDto;
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
    public class TagController : ControllerBase
    {
        private IMapper mapper;
        ITagManager tagManager;

        public TagController(IMapper mapper,ITagManager tagManager)
        {
            this.mapper = mapper;
            this.tagManager = tagManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTagsAsync()
        {
            return Ok(await tagManager.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdTagAsync(int id)
        {
            return Ok(await tagManager.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddTagAsync(AddTagDto addTagDto)
        {
            await tagManager.AddAsync(mapper.Map<Tag>(addTagDto));
            return Created("", addTagDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ChangeTagNameAsync(int id,AddTagDto addTagDto)
        {
            var tag = await tagManager.GetByIdAsync(id);
            if (tag != null)
            {
                tag.Name = addTagDto.Name;
                await tagManager.UpdateAsync(tag);
                return NoContent();
            }
            else
                return BadRequest("Tag Bulunamadı");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTagAsync(int id)
        {
            var tag=await tagManager.GetByIdAsync(id);
            if (tag != null)
            {
                await tagManager.RemoveAsync(tag);
                return NoContent();
            }
            else
                return BadRequest("Tag Bulunamadı");
        }
    }
}
