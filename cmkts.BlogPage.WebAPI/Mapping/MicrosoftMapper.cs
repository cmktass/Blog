using AutoMapper;
using cmkts.BlogPage.Entity.Entities;
using cmkts.BlogPage.WebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cmkts.BlogPage.WebAPI.Mapping
{
    public class MicrosoftMapper:Profile
    {
        public MicrosoftMapper()
        {
            CreateMap<User, UserInfoDto>();
            CreateMap<UserInfoDto, User>();
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
        }
    }
}
