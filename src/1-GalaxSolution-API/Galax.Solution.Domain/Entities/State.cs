using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class State : Entity, IAggregateRoot
    {
        public State(Guid id, string name, string uf, bool actived)
        {
            Id = id;
            Name = name;
            UF = uf;
            Actived = actived; ;
        }
        
        
        public State() { }
        
        public string Name { get; private set; }
        public string UF { get; private set; }
        public bool Actived { get; private set; }
        public Country Country { get; private set; }
        

        
    }
}
