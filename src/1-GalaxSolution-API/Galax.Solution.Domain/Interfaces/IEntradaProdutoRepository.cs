using Galax.Solution.Domain.Entities;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IEntradaProdutoRepository : IRepository<EntradaProduto>
    {
        Task<EntradaProduto> GetById(Guid id);
        Task<EntradaProduto> GetByNumero(string numero);
        Task<EntradaProduto> GetByData(DateTime data);
        Task<IEnumerable<EntradaProduto>> GetAll();

        void Add(EntradaProduto entradaProduto);
        void Update(EntradaProduto entradaProduto);
        void Remove(EntradaProduto entradaProduto);
        
    }
}