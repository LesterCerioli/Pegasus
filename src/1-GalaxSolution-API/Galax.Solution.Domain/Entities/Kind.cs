using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class Kind : Entity, IAggregateRoot
    {
        public Kind(bool fisica, bool juridica)
        {
            Fisica = fisica;
            Juridica = juridica;
        }
        
        protected Kind() { }
        public bool Fisica { get; set; }
        public bool Juridica { get; set; }
                                                                                                                                                                                                                                                                                                                                                                                            

        
    }
}
