using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class CPF : Entity, IAggregateRoot

    {
        public CPF(Guid id, string numCPF)
        {
            Id = id;
            NumCPF = numCPF;

        }

        protected CPF() {}
        public string NumCPF {get; set;}
<<<<<<< HEAD

        public IList<StockUser> StockUsers { get; private set; }

=======
>>>>>>> master
        
    }
}