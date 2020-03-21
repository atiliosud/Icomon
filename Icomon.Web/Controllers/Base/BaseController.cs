using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Icomon.Domain.Interfaces.Services;
using Icomon.Web.Utils;
using Icomon.Web.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;

namespace Icomon.Web.Controllers.Base
{
    public abstract class BaseController : Controller
    {
        private readonly IMemoryCache _memoryCache;
        protected readonly IServiceProvider _services;

        public BaseController(IMemoryCache memoryCache, IServiceProvider services)
        {
            _memoryCache = memoryCache;
            _services = services;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var categories = HttpContext.Session.GetObjectFromJson<List<UserViewModel>>("Users");

            if (categories == null)
            {
                HttpContext.Session.SetObjectAsJson("Users", GetCachedUsers());
            }
        }

        protected IList<UserViewModel> GetCachedUsers()
        {
            List<UserViewModel> users;
            bool exists = _memoryCache.TryGetValue("Users", out users);
            if (!exists)
            {
                users = UpdateUsersCache();
            }
            return users;
        }

        protected List<UserViewModel> UpdateUsersCache()
        {
            var categoryService = (IUserService)_services.GetService(typeof(IUserService));

            var categoriesDTO = categoryService.GetAllActive();
            var categories = Mapper.Map<List<UserViewModel>>(categoriesDTO);

            var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(30));

            _memoryCache.Set("Users", categories, cacheEntryOptions);

            UpdateUsersCache();

            return categories;
        }

        protected void UpdateUsersSession()
        {
            var categories = GetCachedUsers();

            HttpContext.Session.SetObjectAsJson("Categories", GetCachedUsers());
        }
    }
}
