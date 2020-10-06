using Galax.Solution.Domain.Entities;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IEntradaProdutoRepository : IRepository<ProductInput>
    {
        Task<ProductInput> GetById(Guid id);
        Task<ProductInput> GetByNumero(string numero);
        Task<ProductInput> GetByData(DateTime data);
        Task<IEnumerable<ProductInput>> GetAll();

        void Add(ProductInput entradaProduto);
        void Update(ProductInput entradaProduto);
        void Remove(ProductInput entradaProduto);
        
    }
}