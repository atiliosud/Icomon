using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Icomon.Infra.DTO;

namespace Icomon.Domain.Interfaces.Repository
{
    public interface IBaseRepository<TEntity, TEntityDTO> : IDisposable
         where TEntity : class
         where TEntityDTO : IEntityDTO
    {
        void Add(TEntityDTO entity);
        TEntityDTO GetById(int id);
        IEnumerable<TEntityDTO> GetAll();
        void Update(TEntityDTO entity);
        void Remove(int id);
    }
}
