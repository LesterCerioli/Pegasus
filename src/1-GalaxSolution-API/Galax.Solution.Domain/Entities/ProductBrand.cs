using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class ProductBrand : Entity, IAggregateRoot
    {

        public ProductBrand(Guid id, string name, bool actived)
        {
            Id = id;
            Name = name;
            Actived = actived;
        }
        
        public ProductBrand() { }
        public string Name { get; private set; }
        public bool Actived { get; private set; }


        
    }
}
