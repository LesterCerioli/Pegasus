using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Galax.Solution.Domain.Entities;
using NetDevPack.Data;

namespace Galax.Solution.Domain.Interfaces
{
    public interface ISaidaProdutoRepository : IRepository<ProductOutput>
    {
        Task<ProductOutput> GetById(Guid id);
        Task<ProductOutput> GetByNumero(string numero);
        Task<ProductOutput> GetByData(DateTime data);
        Task<IEnumerable<ProductOutput>> GetAll();

        void Add(ProductOutput saidaProduto);
        void Update(ProductOutput saidaProduto);
        void Remove(ProductOutput saidaProduto);

        
        
    }
}