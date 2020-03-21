using System;
using System.Collections.Generic;
using System.Text;

namespace Icomon.Infra.DTO
{
    public class UserDTO : IEntityDTO
    {
        public int Id { get; set; }
        public string Registration { get; set; }
        public string Name { get; set; }
        public string Higher { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Active { get; set; }
    }
}
