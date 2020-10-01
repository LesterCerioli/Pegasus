using Galax.Solution.Domain.Entities;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Galax.Solution.Domain.Interfaces
{
    public interface ICPFRepository : IRepository<CPF>
    {
        Task<CPF> GetById(Guid id);
        Task<CPF> GetByNumCPF(string numCPF);
        Task<IEnumerable<CPF>> GetAll();

        void Add(CPF cPF);
        void Update(CPF cPF);
        void Remove(CPF cPF);

        
    }
}