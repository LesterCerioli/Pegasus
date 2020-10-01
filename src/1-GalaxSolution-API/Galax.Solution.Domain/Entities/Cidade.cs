using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class Cidade : Entity, IAggregateRoot
    {
        public Cidade(Guid id, string nome, bool ativo)
        {
            Id = id;
            Nome = nome;
            Ativo = ativo;
        }
        
        protected Cidade() { }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public int IdEstado { get; set; }
        public virtual Estado Estados { get; set; }




    }

    
}
