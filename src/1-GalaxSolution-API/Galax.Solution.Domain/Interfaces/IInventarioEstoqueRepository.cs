using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Galax.Solution.Domain.Entities;
using Galax.Solution.Domain.Events.InventarioEstoqueEvents;
using NetDevPack.Data;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IInventarioEstoqueRepository : IRepository<StockInventory>
    {
        Task<IInventarioEstoqueRepository> GetById(Guid id);
        Task<StockInventory> GetByData(DateTime data);
        Task<IEnumerable<StockInventory>> GetAll();

        void Add(StockInventory inventarioEstoque);
        void Update(StockInventory inventarioEstoque);
        void Remove(StockInventory inventarioEstoque);
        void Remove(IInventarioEstoqueRepository inventarioEstoque);
        void AddDomainEvent(InventarioEstoqueRemovedEvent inventarioEstoqueRemovedEvent);
    }
}