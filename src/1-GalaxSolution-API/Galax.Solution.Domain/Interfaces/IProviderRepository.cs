using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Galax.Solution.Domain.Entities;
using NetDevPack.Data;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IProviderRepository : IRepository<Provider>
    {
        Task<Provider> GetById(Guid id);
        Task<Provider> GetByFantasyName(string fasntasyName);
        Task<Provider> GetBySocialReason(string socialReason);
        Task<IEnumerable<Provider>> GetAll();

        void Add(Provider provider);
        void Update(Provider provider);
        void Remove(Provider provider);
        
    }
}