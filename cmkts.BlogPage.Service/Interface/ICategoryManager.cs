using cmkts.BlogPage.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cmkts.BlogPage.Service.Interface
{
    public interface ICategoryManager:IGenericManager<Category>
    {
        Task<Category> GetCategoryByName(string name);
        Task<List<Category>> GetAllCategoryWithPostCount();
    }
}
