using Galax.Solution.Domain.Entities;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IUsuarioEstoqueRepository : IRepository<UsuarioEstoque>
    {
        Task<UsuarioEstoque> GetById(Guid id);
        Task<UsuarioEstoque> GetByEmail(string email);
        Task<IEnumerable<UsuarioEstoque>> GetAll();

        void Add(UsuarioEstoque usuarioEstoque);
        void Update(UsuarioEstoque usuarioEstoque);
        void Remove(UsuarioEstoque usuarioEstoque);
    }
}
