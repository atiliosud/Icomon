using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Icomon.Infra.DTO;

namespace Icomon.Domain.Interfaces.Services
{
    public interface IUserService : IBaseService<UserDTO>
    {
        IEnumerable<UserDTO> GetAllActive();
    }
}
