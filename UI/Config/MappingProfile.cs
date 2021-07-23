using AutoMapper;
using Common.HttpHelpers;
using Domain;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Config
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            AllowNullCollections = true;
            AllowNullDestinationValues = true;
            CreateMap(typeof(EResponseBase<>), typeof(EResponseBase<>), MemberList.Source);
            CreateMap(typeof(ProductV1), typeof(Product));
            CreateMap(typeof(Product), typeof(ProductV1));
        }
    }
}
