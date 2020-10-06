using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Galax.Solution.Domain.Entities;
using NetDevPack.Data;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IProdutoRepository : IRepository<Product>
    {
        Task<Product> GetById(Guid id);
        Task<Product> GetByNome(string nome);
        Task<Product> GetByData(DateTime data);
        Task<IEnumerable<Product>> GetAll();

        void Add(Product produto);
        void Update(Product produto);
        void Remove(Product produto);

        
    }
}