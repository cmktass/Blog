using cmkts.BlogPage.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cmkts.BlogPage.Service.Interface
{
    public interface IPostManager:IGenericManager<Post>
    {
        Task<List<Post>> GetAllPostWithCategories();
    }
}
