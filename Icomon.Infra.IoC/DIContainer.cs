using System;
using Icomon.Domain.Interfaces.Repository;
using Icomon.Domain.Interfaces.Services;
using Icomon.Domain.Services;
using Icomon.Infra.Data.Context;
using Icomon.Infra.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Icomon.Infra.IoC
{
    public static class DIContainer
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            services.AddScoped<DbContext, DataContext>();

            services.AddTransient<IUserRepository, UserRepository>();

            services.AddTransient<IUserService, UserService>();
        }
    }
}
