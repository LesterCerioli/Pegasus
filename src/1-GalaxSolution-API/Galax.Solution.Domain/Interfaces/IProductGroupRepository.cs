using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Galax.Solution.Domain.Entities;
using NetDevPack.Data;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IProductGroupRepository : IRepository<ProductGroup>
    {
        Task<ProductGroup> GetById(Guid id);
        Task<ProductGroup> GetByName(string name);
        Task<IEnumerable<ProductGroup>> GetAll();

        void Add(ProductGroup productGroup);
        void Update(ProductGroup productGroup);
        void Remove(ProductGroup productGroup);
        
        
    }
}
