using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class Country : Entity, IAggregateRoot
    {

        public Country(Guid id, string name, string code, bool actived)
        {
            Id = id;
            Name = name;
            Code = code;
            Actived = actived;
        }
        
        
        protected Country() { }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool Actived { get; set; }


        
    }
}
