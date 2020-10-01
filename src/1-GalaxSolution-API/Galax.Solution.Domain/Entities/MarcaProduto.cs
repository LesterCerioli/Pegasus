using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class MarcaProduto : Entity, IAggregateRoot
    {

        public MarcaProduto(Guid id, string nome, bool ativo)
        {
            Id = id;
            Nome = nome;
            Ativo = ativo;
        }
        
        public MarcaProduto() { }
        public string Nome { get; set; }
        public bool Ativo { get; set; }


        
    }
}
