using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Galax.Solution.Domain.Entities;
using NetDevPack.Data;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IEstadoRepository : IRepository<Estado>
    {
        Task<Estado> GetById(Guid id);
        Task<Estado> GetByNome(string name);
        Task<Estado> GetByUF(string uf);
        Task<IEnumerable<Estado>> GetAll();

        void Add(Estado estado);
        void Update(Estado estado);
        void Remove(Estado estado);
    }
}
