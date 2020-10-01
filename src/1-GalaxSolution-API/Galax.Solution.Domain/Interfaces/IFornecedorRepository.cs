using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Galax.Solution.Domain.Entities;
using NetDevPack.Data;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> GetById(Guid id);
        Task<Fornecedor> GetByNomeFantasia(string nomeFantasia);
        Task<Fornecedor> GetByRazaoSocial(string razaoSocial);
        Task<IEnumerable<Fornecedor>> GetAll();

        void Add(Fornecedor fornecedor);
        void Update(Fornecedor fornecedor);
        void Remove(Fornecedor fornecedor);
        
    }
}