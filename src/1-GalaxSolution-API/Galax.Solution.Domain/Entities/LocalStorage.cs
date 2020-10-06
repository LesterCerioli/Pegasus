using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class LocalStorage : Entity, IAggregateRoot
    {

        public LocalStorage(Guid id, string name, bool actived)
        {
            Id = id;
            Name = name;
            Actived = actived;
        }

        protected LocalStorage() { }
        public string Name { get; private set; }
        public bool Actived { get; private set; }
        public IList<LocalDataStoreSlot> LocalDataStores { get; private set; }


        
    }
}
