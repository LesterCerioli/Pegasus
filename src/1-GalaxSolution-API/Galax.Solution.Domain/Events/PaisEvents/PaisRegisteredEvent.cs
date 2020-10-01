using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.PaisEvents
{
    public class PaisRegisteredEvent : Event 
    {
        public PaisRegisteredEvent(Guid id, string nome, string codigo, bool ativo)
        {
            Id = id;
            Nome = nome;
            Codigo = codigo;
            Ativo = ativo;
            AggregateId = id;
        }

        public Guid Id { get; set; }
        public string Nome { get; private set; }
        public string Codigo { get; private set; }
        public bool Ativo { get; private set; }

    }
}

