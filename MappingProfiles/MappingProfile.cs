﻿using AutoMapper;
using Insurance.Models;
using Insurance.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyResource>();
            CreateMap<InsType, InsTypeResource>();
        }
    }
}
