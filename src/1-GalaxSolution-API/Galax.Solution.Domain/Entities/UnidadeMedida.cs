using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class UnidadeMedida : Entity, IAggregateRoot
    {
        
        public UnidadeMedida(Guid id, string nome, string sigla, bool ativo)
        {
            Id = id;
            Nome = nome;
            Ativo = ativo;
        }
        
        public UnidadeMedida() { }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public bool Ativo { get; set; }


        
    }
}
