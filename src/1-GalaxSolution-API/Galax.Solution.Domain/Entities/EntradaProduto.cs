using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class EntradaProduto : Entity, IAggregateRoot
    {



        public EntradaProduto(Guid id, string numero, DateTime data, int quantidade)
        {
            Id = id;
            Numero = numero;
            Data = Data;
            Quantidade = quantidade;

        }

        protected EntradaProduto() { }
        public string Numero { get; set; }
        public DateTime Data { get; set; }
        public int Quantidade { get; set; }
        public int IdProduto { get; set; }
        public virtual Produto Produtos { get; set; }

        
    }
}
