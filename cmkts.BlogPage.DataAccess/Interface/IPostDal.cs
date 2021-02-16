using cmkts.BlogPage.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cmkts.BlogPage.DataAccess.Interface
{
    public interface IPostDal:IGenericDal<Post>
    {
        Task<List<Post>> GetAllPostWithCategories();
    }
}
