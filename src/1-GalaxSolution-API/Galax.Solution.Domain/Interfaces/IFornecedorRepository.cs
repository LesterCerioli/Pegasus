using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Galax.Solution.Domain.Entities;
using NetDevPack.Data;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IFornecedorRepository : IRepository<Provider>
    {
        Task<Provider> GetById(Guid id);
        Task<Provider> GetByNomeFantasia(string nomeFantasia);
        Task<Provider> GetByRazaoSocial(string razaoSocial);
        Task<IEnumerable<Provider>> GetAll();

        void Add(Provider fornecedor);
        void Update(Provider fornecedor);
        void Remove(Provider fornecedor);
        
    }
}