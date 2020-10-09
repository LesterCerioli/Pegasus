using Galax.Solution.Domain.Entities;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IProfileRepository : IRepository<StockProfile>
    {
        Task<StockProfile> GetById(Guid id);
        Task<StockProfile> GetByNome(string name);
        Task<IEnumerable<Profile>> GetAll();

        void Add(Profile profile);
        void Update(Profile profile);
        void Remove(Profile profile);
    }
}
