using Galax.Solution.Domain.Entities;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Interfaces
{
    public  interface IProductBrandRepository : IRepository<ProductBrand>
    {
        Task<ProductBrand> GetById(Guid id);
        Task<ProductBrand> GetByNome(string name);
        Task<IEnumerable<ProductBrand>> GetAll();

        void Add(ProductBrand productBrand);
        void Update(ProductBrand productBrand);
        void Remove(ProductBrand productBrand);
    }
}
