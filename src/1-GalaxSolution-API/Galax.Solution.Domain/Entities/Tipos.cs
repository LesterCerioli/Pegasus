using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class Tipo : Entity, IAggregateRoot
    {
        public Tipo(bool fisica, bool juridica)
        {
            Fisica = fisica;
            Juridica = juridica;
        }
        
        protected Tipo() { }
        public bool Fisica { get; set; }
        public bool Juridica { get; set; }
                                                                                                                                                                                                                                                                                                                                                                                            

        
    }
}
