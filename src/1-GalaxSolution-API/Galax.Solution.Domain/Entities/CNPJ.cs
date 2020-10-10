using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class CNPJ : Entity, IAggregateRoot
    {
        public CNPJ(Guid id, string numCNPJ)
        {
            Id = id;
            NumCNPJ = numCNPJ;

        }

        protected CNPJ() {}

        public string NumCNPJ {get; private set;}
        public virtual Provider Provider {get; private set;}

        public string NumCNPJ {get; set;}
        public int FornecedorId {get; set;}
        public virtual Fornecedor Fornecedor {get; set;}

    }
}