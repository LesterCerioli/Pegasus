using Galax.Solution.Domain.Entities;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Interfaces
{
    public interface ILocalArmazenamentoRepository : IRepository<LocalArmazenamento>
    {
        Task<LocalArmazenamento> GetById(Guid id);
        Task<LocalArmazenamento> GetByNome(string nome);
        Task<IEnumerable<LocalArmazenamento>> GetLocalArmazenamentos() ;

        void Add(LocalArmazenamento localArmazenamento);
        void Update(LocalArmazenamento localArmazenamento);
        void Remove(LocalArmazenamento localArmazenamento);
    }
}
