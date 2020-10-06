using Galax.Solution.Domain.Entities;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IPerfilRepository : IRepository<StockProfile>
    {
        Task<StockProfile> GetById(Guid id);
        Task<StockProfile> GetByNome(string nome);
        Task<IEnumerable<StockProfile>> GetAll();

        void Add(StockProfile perfil);
        void Update(StockProfile perfil);
        void Remove(StockProfile perfil);
    }
}
