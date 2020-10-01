using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class LocalArmazenamento : Entity, IAggregateRoot
    {

        public LocalArmazenamento(Guid id, string nome, bool ativo)
        {
            Id = id;
            Nome = nome;
            Ativo = ativo;
        }
        
        protected LocalArmazenamento() { }
        public string Nome { get; set; }
        public bool Ativo { get; set; }


        
    }
}
