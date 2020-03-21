using System;
using System.Collections.Generic;
using System.Text;
using Icomon.Domain.Interfaces.Repository;
using Icomon.Domain.Interfaces.Services;
using Icomon.Domain.Models;
using Icomon.Infra.DTO;

namespace Icomon.Domain.Services
{
    public class UserService : BaseService<User, UserDTO>, IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) : base(userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<UserDTO> GetAllActive()
        {
            return _userRepository.GetAllActive();
        }
    }
}
