using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class Estado : Entity, IAggregateRoot
    {
        public Estado(Guid id, string nome, string uf, bool ativo)
        {
            Id = id;
            Nome = nome;
            UF = uf;
            Ativo = ativo;
        }
        
        
        public Estado() { }
        
        public string Nome { get; set; }
        public string UF { get; set; }
        public bool Ativo { get; set; }
        public int IdPais { get; set; }
        public virtual Pais Paises { get; set; }

        
    }
}
