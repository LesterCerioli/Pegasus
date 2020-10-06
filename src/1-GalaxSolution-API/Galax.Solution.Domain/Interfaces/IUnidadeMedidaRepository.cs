using Galax.Solution.Domain.Entities;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IUnidadeMedidaRepository : IRepository<MeasurementUnit>
    {
        Task<MeasurementUnit> GetById(Guid id);
        Task<MeasurementUnit> GetBySigla(string sigla);
        Task<IEnumerable<MeasurementUnit>> GetAll();

        void Add(MeasurementUnit unidadeMedida);
        void Update(MeasurementUnit unidadeMedida);
        void Remove(MeasurementUnit unidadeMedida);
    }
}
