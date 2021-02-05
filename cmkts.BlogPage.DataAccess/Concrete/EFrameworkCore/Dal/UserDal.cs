using cmkts.BlogPage.DataAccess.Concrete.EFrameworkCore.BlogPageContext;
using cmkts.BlogPage.DataAccess.Interface;
using cmkts.BlogPage.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cmkts.BlogPage.DataAccess.Concrete.EFrameworkCore.Dal
{
    public class UserDal : GenericDal<User>, IUserDal
    {
        
    }
}
