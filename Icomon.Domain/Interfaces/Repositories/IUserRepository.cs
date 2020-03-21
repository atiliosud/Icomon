using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Icomon.Domain.Models;
using Icomon.Infra.DTO;

namespace Icomon.Domain.Interfaces.Repository
{
    public interface IUserRepository : IBaseRepository<User, UserDTO>
    {
        IEnumerable<UserDTO> GetAllActive();
    }
}
