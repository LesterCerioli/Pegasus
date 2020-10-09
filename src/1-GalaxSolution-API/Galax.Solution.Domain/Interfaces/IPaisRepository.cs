using Galax.Solution.Domain.Entities;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IPaisRepository : IRepository<Pais>
    {
        Task<Pais> GetById(Guid id);
        Task<Pais> GetByNome(string nome);
        Task<IEnumerable<Pais>> GetAll();

        void Add(Pais pais);
        void Update(Pais pais);
        void Remove(Pais pais);
    }
}
