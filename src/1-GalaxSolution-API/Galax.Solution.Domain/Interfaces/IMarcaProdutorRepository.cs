using Galax.Solution.Domain.Entities;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Interfaces
{
    public  interface IMarcaProdutorRepository : IRepository<ProductBrand>
    {
        Task<ProductBrand> GetById(Guid id);
        Task<ProductBrand> GetByNome(string nome);
        Task<IEnumerable<ProductBrand>> GetAll();

        void Add(ProductBrand marcaProduto);
        void Update(ProductBrand marcaProduto);
        void Remove(ProductBrand marcaProduto);
    }
}
