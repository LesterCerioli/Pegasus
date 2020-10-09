using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Galax.Solution.Domain.Entities;
using NetDevPack.Data;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetById(Guid id);
        Task<Product> GetByName(string name);
        Task<Product> GetByDate(DateTime date);
        Task<IEnumerable<Product>> GetAll();

        void Add(Product prouct);
        void Update(Product product);
        void Remove(Product product);

        
    }
}