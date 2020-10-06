using Galax.Solution.Domain.Core.Events;
using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxSolution.Infrastructure.Data.Repository.EventSourcing.Sql
{
    public class EventStockSQLRepository : IEventStock
    {

        private readonly IEventStockRepository eventStock;
        
        
        
        public void Save<T>(T theEvent) where T : Event
        {
            throw new NotImplementedException();
        }
    }
}
