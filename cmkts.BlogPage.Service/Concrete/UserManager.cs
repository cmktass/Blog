using cmkts.BlogPage.DataAccess.Concrete.EFrameworkCore.Dal;
using cmkts.BlogPage.DataAccess.Interface;
using cmkts.BlogPage.Entity.Entities;
using cmkts.BlogPage.Service.Interface;

namespace cmkts.BlogPage.Service.Concrete
{
    public class UserManager:GenericManager<User>,IUserManager
    {
        private IGenericDal<User> genericDal;

        public UserManager(IGenericDal<User> genericDal) :base(genericDal)
        {
            this.genericDal = genericDal;
        }
    }
}
