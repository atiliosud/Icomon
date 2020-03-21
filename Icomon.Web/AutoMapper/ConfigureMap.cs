using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Icomon.Infra.AutoMapper;

namespace Icomon.Web.AutoMapper
{
    public static class ConfigureMap
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<DataMappingProfile>();
                cfg.AddProfile<WebMappingProfile>();
            });
        }
    }
}
