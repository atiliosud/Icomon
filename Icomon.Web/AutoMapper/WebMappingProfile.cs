using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Icomon.Infra.DTO;
using Icomon.Web.ViewModel;

namespace Icomon.Web.AutoMapper
{
    public class WebMappingProfile : Profile
    {
        public WebMappingProfile()
        {
            CreateMap<UserDTO, UserViewModel>()
                .ReverseMap()
                .ForMember(dto => dto.CreatedAt, opt => opt.Ignore());
        }
    }
}
