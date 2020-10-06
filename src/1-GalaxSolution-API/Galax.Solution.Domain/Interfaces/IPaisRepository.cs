using Galax.Solution.Domain.Entities;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IPaisRepository : IRepository<Country>
    {
        Task<Country> GetById(Guid id);
        Task<Country> GetByNome(string nome);
        Task<IEnumerable<Country>> GetAll();

        void Add(Country pais);
        void Update(Country pais);
        void Remove(Country pais);
    }
}
