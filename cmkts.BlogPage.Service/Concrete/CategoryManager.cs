using cmkts.BlogPage.DataAccess.Concrete.EFrameworkCore.Dal;
using cmkts.BlogPage.DataAccess.Interface;
using cmkts.BlogPage.Entity.Entities;
using cmkts.BlogPage.Service.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace cmkts.BlogPage.Service.Concrete
{
    public class CategoryManager:GenericManager<Category>, ICategoryManager
    {
        private IGenericDal<Category> genericDal;
        private ICategoryDal categoryDal;
        public CategoryManager(IGenericDal<Category> genericDal, ICategoryDal categoryDal) :base(genericDal)
        {
            this.genericDal = genericDal;
            this.categoryDal = categoryDal;
        }

        public Task<List<Category>> GetAllCategoryWithPostCount()
        {
            return categoryDal.GetAllCategoryWithPostCount();
        }

        public Task<Category> GetCategoryByName(string name)
        {
            return categoryDal.GetCategoryByName(name);
        }
    }
}
