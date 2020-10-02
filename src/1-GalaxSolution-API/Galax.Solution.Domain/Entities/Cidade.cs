using NetDevPack.Domain;
using System;

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
        public string Nome { get; private set; }
        public bool Ativo { get; private set; }
        public int IdEstado { get; private set; }
        public virtual Estado Estados { get; private set; }




    }

    
}
