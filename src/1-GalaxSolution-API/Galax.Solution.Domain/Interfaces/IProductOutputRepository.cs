using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Galax.Solution.Domain.Entities;
using NetDevPack.Data;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IProductOutputRepository : IRepository<ProductOutput>
    {
        Task<ProductOutput> GetById(Guid id);
        Task<ProductOutput> GetByNumber(string number);
        Task<ProductOutput> GetByDate(DateTime date);
        Task<IEnumerable<ProductOutput>> GetAll();

        void Add(ProductOutput productOutput);
        void Update(ProductOutput productOutput);
        void Remove(ProductOutput productOutput);

        
        
    }
}