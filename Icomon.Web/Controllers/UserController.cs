using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Icomon.Domain.Interfaces.Services;
using Icomon.Infra.DTO;
using Icomon.Presentation.Controllers.Base;
using Icomon.Web.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace Icomon.Web.Controllers
{
    public class UserController : EntityBaseController<IUserService, UserDTO, UserViewModel>
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService, IMemoryCache memoryCache, IServiceProvider services)
            : base(userService, memoryCache, services)
        {
            _userService = userService;
        }

        // GET: product/1
        public IActionResult Index(int id)
        {
            var user = _userService.GetById(id);
            var mappedUser = Mapper.Map<UserViewModel>(user);

            return View(mappedUser);
        }
    }
}
