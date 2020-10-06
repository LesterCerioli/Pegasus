using Galax.Solution.Domain.Entities;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Interfaces
{
    
    public interface ICityRepository : IRepository<City>
    {
        Task<City> GetById(Guid id);
        Task<City> GetByName(string Name);
        Task<IEnumerable<City>> GetAll();

        void Add(City city);
        void Update(City city);
        void Remove(City city);
    }
}
