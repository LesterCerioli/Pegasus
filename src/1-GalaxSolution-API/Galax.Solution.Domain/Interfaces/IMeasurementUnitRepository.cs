using Galax.Solution.Domain.Entities;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IMeasurementUnitRepository : IRepository<MeasurementUnit>
    {
        Task<MeasurementUnit> GetById(Guid id);
        Task<MeasurementUnit> GetBySymbol(string symbol);
        Task<IEnumerable<MeasurementUnit>> GetAll();

        void Add(MeasurementUnit measurementUnit);
        void Update(MeasurementUnit measurementUnit);
        void Remove(MeasurementUnit measurementUnit);
    }
}
