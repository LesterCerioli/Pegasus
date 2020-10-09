using Galax.Solution.Domain.Entities;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IStockUserRepository : IRepository<StockUser>
    {
        Task<StockUser> GetById(Guid id);
        Task<StockUser> GetByEmail(string email);
        Task<IEnumerable<StockUser>> GetAll();

        void Add(StockUser stockUser);
        void Update(StockUser stockUser);
        void Remove(StockUser stockUser);
    }
}
