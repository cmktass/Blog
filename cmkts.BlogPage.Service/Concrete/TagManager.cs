using cmkts.BlogPage.DataAccess.Interface;
using cmkts.BlogPage.Entity.Entities;
using cmkts.BlogPage.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace cmkts.BlogPage.Service.Concrete
{
    public class TagManager:GenericManager<Tag>,ITagManager
    {
        private IGenericDal<Tag> genericDal;
        public TagManager(IGenericDal<Tag> genericDal):base(genericDal)
        {
            this.genericDal = genericDal;
        }
    }
}
