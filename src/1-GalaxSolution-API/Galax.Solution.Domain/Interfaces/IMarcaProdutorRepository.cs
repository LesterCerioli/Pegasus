using Galax.Solution.Domain.Entities;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Interfaces
{
    public  interface IMarcaProdutorRepository : IRepository<MarcaProduto>
    {
        Task<MarcaProduto> GetById(Guid id);
        Task<MarcaProduto> GetByNome(string nome);
        Task<IEnumerable<MarcaProduto>> GetAll();

        void Add(MarcaProduto marcaProduto);
        void Update(MarcaProduto marcaProduto);
        void Remove(MarcaProduto marcaProduto);
    }
}
