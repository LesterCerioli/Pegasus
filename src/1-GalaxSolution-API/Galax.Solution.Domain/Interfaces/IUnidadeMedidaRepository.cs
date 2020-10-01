using Galax.Solution.Domain.Entities;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IUnidadeMedidaRepository : IRepository<UnidadeMedida>
    {
        Task<UnidadeMedida> GetById(Guid id);
        Task<UnidadeMedida> GetBySigla(string sigla);
        Task<IEnumerable<UnidadeMedida>> GetAll();

        void Add(UnidadeMedida unidadeMedida);
        void Update(UnidadeMedida unidadeMedida);
        void Remove(UnidadeMedida unidadeMedida);
    }
}
