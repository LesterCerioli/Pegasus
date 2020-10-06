using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Galax.Solution.Domain.Entities;
using NetDevPack.Data;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IGrupoProdutoRepository : IRepository<ProductGroup>
    {
        Task<ProductGroup> GetById(Guid id);
        Task<ProductGroup> GetByNome(string nome);
        Task<IEnumerable<ProductGroup>> GetAll();

        void Add(ProductGroup grupoProduto);
        void Update(ProductGroup grupoProduto);
        void Remove(ProductGroup grupoProduto);
        
        
    }
}
