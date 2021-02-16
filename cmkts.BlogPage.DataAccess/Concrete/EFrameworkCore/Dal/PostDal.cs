using cmkts.BlogPage.DataAccess.Concrete.EFrameworkCore.BlogPageContext;
using cmkts.BlogPage.DataAccess.Interface;
using cmkts.BlogPage.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cmkts.BlogPage.DataAccess.Concrete.EFrameworkCore.Dal
{
    public class PostDal : GenericDal<Post>, IPostDal
    {
        public async Task<List<Post>> GetAllPostWithCategories()
        {
            using(var db=new BPContext())
            {
                return await db.Posts.Include(i => i.PostCategories).ThenInclude(i => i.Category).ToListAsync();
            }
        }
    }
}
