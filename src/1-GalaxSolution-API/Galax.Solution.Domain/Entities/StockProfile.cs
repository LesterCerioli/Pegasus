using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class StockProfile : Entity, IAggregateRoot
    {

        public StockProfile(Guid id, string name, bool actived)
        {
            Id = id;
            Name = name;
            Actived = actived;
        }
        
        protected StockProfile() { }
        public string Name { get; private set; }
        public bool Actived { get; private set; }
        public IList<StockUser> Stockusers { get; private set; }



        
    }
}
