using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class City : Entity, IAggregateRoot
    {
        public City(Guid id, string name, bool actived)
        {
            Id = id;
            Name = name;
            Actived = actived;
        }
        
        protected City() { }
        public string Name { get; private set; }
        public bool Actived { get; private set; }
        public IList<State> States { get; private set; }




    }

    
}
