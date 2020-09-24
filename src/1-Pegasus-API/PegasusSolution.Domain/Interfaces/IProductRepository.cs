using NetDevPack.Data;
using PegasusSolution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PegasusSolution.Domain.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetById(Guid id);
        Task<Product> GetByName(string name);
        Task<IEnumerable<Product>> GetAll();

        void Add(Product product);
        void Update(Product product);
        void Remove(Product product);

    }
}
