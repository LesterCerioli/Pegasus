using Galax.Solution.Domain.Entities;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IPerfilRepository : IRepository<Perfil>
    {
        Task<Perfil> GetById(Guid id);
        Task<Perfil> GetByNome(string nome);
        Task<IEnumerable<Perfil>> GetAll();

        void Add(Perfil perfil);
        void Update(Perfil perfil);
        void Remove(Perfil perfil);
    }
}
