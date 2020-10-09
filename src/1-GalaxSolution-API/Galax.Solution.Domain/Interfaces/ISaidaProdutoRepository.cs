using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Galax.Solution.Domain.Entities;
using NetDevPack.Data;

namespace Galax.Solution.Domain.Interfaces
{
    public interface ISaidaProdutoRepository : IRepository<SaidaProduto>
    {
        Task<SaidaProduto> GetById(Guid id);
        Task<SaidaProduto> GetByNumero(string numero);
        Task<SaidaProduto> GetByData(DateTime data);
        Task<IEnumerable<SaidaProduto>> GetAll();

        void Add(SaidaProduto saidaProduto);
        void Update(SaidaProduto saidaProduto);
        void Remove(SaidaProduto saidaProduto);

        
        
    }
}