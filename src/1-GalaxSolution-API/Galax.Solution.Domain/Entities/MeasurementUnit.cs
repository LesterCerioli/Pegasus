using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class MeasurementUnit : Entity, IAggregateRoot
    {
        
        public MeasurementUnit(Guid id, string nome, string sigla, bool ativo)
        {
            Id = id;
            Nome = nome;
            Ativo = ativo;
            Sigla = sigla;
        }
        
        public MeasurementUnit() { }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public bool Ativo { get; set; }


        
    }
}
