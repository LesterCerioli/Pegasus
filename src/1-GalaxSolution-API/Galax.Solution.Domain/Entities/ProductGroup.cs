using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class ProductGroup : Entity, IAggregateRoot
    {
        public ProductGroup(Guid id, string name, bool actived)
        {
            Id = id;
            Name = name;
            Actived = actived;
        }
        protected ProductGroup() { }
        public string Name { get; private set; }
        public bool Actived { get; private set; }


        
    }
}
