using Galax.Solution.Domain.Entities;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Interfaces
{
    
    public interface ICidadeRepository : IRepository<Cidade>
    {
        Task<Cidade> GetById(Guid id);
        Task<Cidade> GetByNome(string Nome);
        Task<IEnumerable<Cidade>> GetAll();

        void Add(Cidade cidade);
        void Update(Cidade cidade);
        void Remove(Cidade cidade);
    }
}
