using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Galax.Solution.Domain.Entities;
using Galax.Solution.Domain.Events.InventarioEstoqueEvents;
using NetDevPack.Data;

namespace Galax.Solution.Domain.Interfaces
{
    public interface IStockInventoryRepository : IRepository<StockInventory>
    {
        Task<IStockInventoryRepository> GetById(Guid id);
        Task<StockInventory> GetByData(DateTime date);
        Task<IEnumerable<StockInventory>> GetAll();

        void Add(StockInventory stockInventory);
        void Update(StockInventory stockInventory);
        void Remove(StockInventory stockInventory);
        void Remove(StockInventoryRepository stockInventory);
        void AddDomainEvent(StockInventoryRemovedEvent stockInventoryRemovedEvent);
    }
}