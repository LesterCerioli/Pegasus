using Galax.Solution.Domain.Entities;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Interfaces
{
    public interface ILocalStorageRepository : IRepository<LocalStorage>
    {
        Task<LocalStorage> GetById(Guid id);
        Task<LocalStorage> GetByName(string nome);
        Task<IEnumerable<LocalStorage>> GetLocalStorage();

        void Add(LocalStorage localStorage);
        void Update(LocalStorage localStorage);
        void Remove(LocalStorage localStorage);
    }
}
