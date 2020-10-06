using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Galax.Solution.Domain.Entities;
using NetDevPack.Data;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IEstadoRepository : IRepository<State>
    {
        Task<State> GetById(Guid id);
        Task<State> GetByNome(string name);
        Task<State> GetByUF(string uf);
        Task<IEnumerable<State>> GetAll();

        void Add(State estado);
        void Update(State estado);
        void Remove(State estado);
    }
}
