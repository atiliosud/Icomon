using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Icomon.Domain.Interfaces.Repository;
using Icomon.Domain.Models;
using Icomon.Infra.Data.Context;
using Icomon.Infra.DTO;

namespace Icomon.Infra.Data.Repository
{
    public class UserRepository : BaseRepository<User, UserDTO>, IUserRepository
    {
        public UserRepository(DataContext context) : base(context)
        {

        }

        public IEnumerable<UserDTO> GetAllActive()
        {
            var activeUsers = All().Where(c => c.Active).ToList();
            return Mapper.Map<List<UserDTO>>(activeUsers);
        }
    }
}
