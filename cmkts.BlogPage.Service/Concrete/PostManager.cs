using cmkts.BlogPage.DataAccess.Interface;
using cmkts.BlogPage.Entity.Entities;
using cmkts.BlogPage.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cmkts.BlogPage.Service.Concrete
{
    public class PostManager:GenericManager<Post>,IPostManager
    {
        private IGenericDal<Post> genericDal;
        private IPostDal postDal;
        public PostManager(IGenericDal<Post> genericDal, IPostDal postDal) :base(genericDal)
        {
            this.genericDal = genericDal;
            this.postDal = postDal;
        }

        public async Task<List<Post>> GetAllPostWithCategories()
        {
            return await postDal.GetAllPostWithCategories();
        }
    }
}
