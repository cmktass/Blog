using cmkts.BlogPage.DataAccess.Concrete.EFrameworkCore.Dal;
using cmkts.BlogPage.Entity.Entities;
using cmkts.BlogPage.Service.Interface;

namespace cmkts.BlogPage.Service.Concrete
{
    public class CategoryManager:GenericManager<Category>, ICategoryManager
    {
        private GenericDal<Category> genericDal;
        public CategoryManager(GenericDal<Category> genericDal):base(genericDal)
        {
            this.genericDal = genericDal;
        }
    }
}
