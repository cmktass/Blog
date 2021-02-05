using cmkts.BlogPage.DataAccess.Concrete.EFrameworkCore.Dal;
using cmkts.BlogPage.DataAccess.Interface;
using cmkts.BlogPage.Service.Concrete;
using cmkts.BlogPage.Service.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace cmkts.BlogPage.Service.IoC
{
    public static class IoCExtentions
    {
        public static void AddDependencies(this IServiceCollection service)
        {
            service.AddScoped(typeof(IGenericDal<>), typeof(GenericDal<>));

            service.AddScoped(typeof(IGenericManager<>), typeof(GenericManager<>));

            service.AddScoped<IUserDal, UserDal>();

            service.AddScoped<IUserManager, UserManager>();

            service.AddScoped<ICategoryDal, CategoryDal>();
            
        }
    }
}
