using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Galax.Solution.Domain.Entities;
using NetDevPack.Data;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IStateRepository : IRepository<State>
    {
        Task<State> GetById(Guid id);
        Task<State> GetByName(string name);
        Task<State> GetByUF(string uf);
        Task<IEnumerable<State>> GetAll();

        void Add(State state);
        void Update(State state);
        void Remove(State state);
    }
}
