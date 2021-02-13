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
    public class UserDal : GenericDal<User>, IUserDal
    {
        public async Task<User> CheckUserAsync(User user)
        {
            using(var db=new BPContext())
            {
               return await db.Users.Where(i => i.Email == user.Email && i.Password == user.Password).FirstOrDefaultAsync();
            }
        }
    }
}
