using cmkts.BlogPage.DataAccess.Concrete.EFrameworkCore.BlogPageContext;
using cmkts.BlogPage.DataAccess.Interface;
using cmkts.BlogPage.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmkts.BlogPage.DataAccess.Concrete.EFrameworkCore.Dal
{
    public class CategoryDal : GenericDal<Category>, ICategoryDal
    {
        public async Task<List<Category>> GetAllCategoryWithPostCount()
        {
            using (var db = new BPContext())
            {
                return await db.Categories.Include(i => i.PostCategories).ToListAsync();
            }
        }

        public async Task<Category> GetCategoryByName(string name)
        {
            using(var db=new BPContext())
            {
                return await db.Categories.Where(i => i.Name == name).FirstOrDefaultAsync();
            }
        }
    }
}
