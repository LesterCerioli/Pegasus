using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class Desconto : Entity, IAggregateRoot
    {
        public Desconto(decimal quantidade, DateTime dataExpira)
        {
            Quantidade = quantidade;
            DataExpira = dataExpira;
        }
        protected Desconto() { }
        public decimal Quantidade { get; private set; }
        public DateTime DataExpira { get; private set; }

        public bool IsValid()
        {
            return DateTime.Compare(DateTime.Now, DataExpira) < 0;
        }
    }
}
