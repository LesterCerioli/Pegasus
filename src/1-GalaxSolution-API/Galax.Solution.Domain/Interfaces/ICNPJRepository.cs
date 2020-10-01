using Galax.Solution.Domain.Entities;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Galax.Solution.Domain.Interfaces
{
    public interface ICNPJRepository : IRepository<CNPJ>
    {
        Task<CNPJ> GetById(Guid id);
        Task<CNPJ> GetByNumCNPJ(string NumCNPJ);
        Task<IEnumerable<CNPJ>> GetAll();

        void Add(CNPJ cNPJ);
        void Update(CNPJ cNPJ);
        void Remove(CNPJ cNPJ);
    }
    


}