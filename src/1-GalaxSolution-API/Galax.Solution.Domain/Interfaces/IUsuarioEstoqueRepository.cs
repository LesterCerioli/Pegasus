using Galax.Solution.Domain.Entities;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IUsuarioEstoqueRepository : IRepository<StockUser>
    {
        Task<StockUser> GetById(Guid id);
        Task<StockUser> GetByEmail(string email);
        Task<IEnumerable<StockUser>> GetAll();

        void Add(StockUser usuarioEstoque);
        void Update(StockUser usuarioEstoque);
        void Remove(StockUser usuarioEstoque);
    }
}
