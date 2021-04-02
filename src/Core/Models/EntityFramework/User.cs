﻿using System.Collections.Generic;
using System.Text.Json;
using AutoMapper;

namespace Bit.Core.Models.EntityFramework
{
    public class User : Table.User
    {

    }

    public class UserMapperProfile : Profile
    {
        public UserMapperProfile()
        {
           CreateMap<Table.User, User>().ReverseMap();
        }
    }
}
