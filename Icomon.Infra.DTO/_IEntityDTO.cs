using System;

namespace Icomon.Infra.DTO
{
    public interface IEntityDTO
    {
        DateTime CreatedAt { get; set; }
        bool Active { get; set; }
    }
}
