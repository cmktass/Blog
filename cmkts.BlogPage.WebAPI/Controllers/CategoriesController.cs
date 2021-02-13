using AutoMapper;
using cmkts.BlogPage.Entity.Entities;
using cmkts.BlogPage.Service.Interface;
using cmkts.BlogPage.WebAPI.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace cmkts.BlogPage.WebAPI.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {


        private ICategoryManager categoryManager;
        private IMapper mapper;
        public CategoriesController(ICategoryManager categoryManager,IMapper mapper)
        {
            this.mapper = mapper;
            this.categoryManager = categoryManager;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {

            
            List<CategoryWithPostCount> categoryWithPostCounts = new List<CategoryWithPostCount>();
            var categories = await categoryManager.GetAllCategoryWithPostCount();
            foreach (var item in categories)
            {
                CategoryWithPostCount categoryWithPostCount = new CategoryWithPostCount();
                categoryWithPostCount.Id = item.Id;
                categoryWithPostCount.Name = item.Name;
                categoryWithPostCount.Count = item.PostCategories.Count;
                categoryWithPostCounts.Add(categoryWithPostCount);
            }
            return Ok(categoryWithPostCounts);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            return Ok(mapper.Map<CategoryDto>(await categoryManager.GetByIdAsync(id)));
        }
        
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateCategory(CategoryDto categoryDto)
        {
            await categoryManager.AddAsync(mapper.Map<Category>(categoryDto));
            return Created("", categoryDto);
        }

        [HttpPut]
        [Authorize]
        public async Task<IActionResult> ChangeCategoryName(string name,string newName)
        {
            Category user= await categoryManager.GetCategoryByName(name);
            if (user == null)
            {
                return BadRequest("Gönderilen isimli kategori bulunamadı");
            }
            else
            {
                if (newName != null)
                {
                    user.Name = newName;
                    await categoryManager.UpdateAsync(user);
                }
                return NoContent();
                    
            }
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteCategoryAsync(int id)
        {
            var cat=await categoryManager.GetByIdAsync(id);
            if(cat != null)
            {
                await categoryManager.RemoveAsync(cat);
                return NoContent();
            }
            else
            {
                return BadRequest("Aranan id bulunamadı");
            }
        }
    }
}
