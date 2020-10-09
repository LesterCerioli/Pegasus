using Galax.Solution.Domain.Entities;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IPtoductInputRepository : IRepository<ProductInput>
    {
        Task<ProductInput> GetById(Guid id);
        Task<ProductInput> GetByNumero(string number);
        Task<ProductInput> GetByData(DateTime date);
        Task<IEnumerable<ProductInput>> GetAll();

        void Add(ProductInput productInput);
        void Update(ProductInput productInput);
        void Remove(ProductInput productInput);
        
    }
}