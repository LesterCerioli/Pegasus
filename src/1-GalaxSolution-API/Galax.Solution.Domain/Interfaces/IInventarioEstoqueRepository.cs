using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Galax.Solution.Domain.Entities;
using Galax.Solution.Domain.Events.InventarioEstoqueEvents;
using NetDevPack.Data;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IInventarioEstoqueRepository : IRepository<InventarioEstoque>
    {
        Task<IInventarioEstoqueRepository> GetById(Guid id);
        Task<InventarioEstoque> GetByData(DateTime data);
        Task<IEnumerable<InventarioEstoque>> GetAll();

        void Add(InventarioEstoque inventarioEstoque);
        void Update(InventarioEstoque inventarioEstoque);
        void Remove(InventarioEstoque inventarioEstoque);
        void Remove(IInventarioEstoqueRepository inventarioEstoque);
        void AddDomainEvent(InventarioEstoqueRemovedEvent inventarioEstoqueRemovedEvent);
    }
}