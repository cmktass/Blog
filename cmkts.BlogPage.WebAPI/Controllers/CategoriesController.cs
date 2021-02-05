using AutoMapper;
using cmkts.BlogPage.DataAccess.Concrete.EFrameworkCore.BlogPageContext;
using cmkts.BlogPage.DataAccess.Concrete.EFrameworkCore.Dal;
using cmkts.BlogPage.DataAccess.Interface;
using cmkts.BlogPage.Entity.Entities;
using cmkts.BlogPage.Service.Concrete;
using cmkts.BlogPage.Service.Interface;
using cmkts.BlogPage.WebAPI.DTO;
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
    public class CategoriesController : ControllerBase
    {


        private ICategoryDal categoryDal;
        public CategoriesController(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            return Ok(await categoryDal.GetByIdAsync(1));
            
        }
    }
}
