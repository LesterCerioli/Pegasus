using Galax.Solution.Domain.Entities;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Interfaces
{
    public interface ICountryRepository : IRepository<Country>
    {
        Task<Country> GetById(Guid id);
        Task<Country> GetByNome(string name);
        Task<IEnumerable<Country>> GetAll();

        void Add(Country country);
        void Update(Country country);
        void Remove(Country country);
    }
}
