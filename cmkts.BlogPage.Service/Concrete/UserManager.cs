using cmkts.BlogPage.DataAccess.Concrete.EFrameworkCore.Dal;
using cmkts.BlogPage.DataAccess.Interface;
using cmkts.BlogPage.Entity.Entities;
using cmkts.BlogPage.Service.Interface;
using System.Threading.Tasks;

namespace cmkts.BlogPage.Service.Concrete
{
    public class UserManager:GenericManager<User>,IUserManager
    {
        private IGenericDal<User> genericDal;
        private IUserDal userDal;

        public UserManager(IGenericDal<User> genericDal,IUserDal userDal) :base(genericDal)
        {
            this.genericDal = genericDal;
            this.userDal = userDal;
        }

        public Task<User> CheckUserAsync(User user)
        {
            return userDal.CheckUserAsync(user);
        }
    }
}
