using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Galax.Solution.Domain.Entities;
using NetDevPack.Data;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<Produto> GetById(Guid id);
        Task<Produto> GetByNome(string nome);
        Task<Produto> GetByData(DateTime data);
        Task<IEnumerable<Produto>> GetAll();

        void Add(Produto produto);
        void Update(Produto produto);
        void Remove(Produto produto);

        
    }
}