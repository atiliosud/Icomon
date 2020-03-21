using System;
using AutoMapper;
using Icomon.Domain.Models;
using Icomon.Infra.DTO;

namespace Icomon.Infra.AutoMapper
{
    public class DataMappingProfile : Profile
    {
        public DataMappingProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
