using Abp.Domain.Entities;
using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Entity = NetDevPack.Domain.Entity;
using IAggregateRoot = NetDevPack.Domain.IAggregateRoot;

namespace Galax.Solution.Domain.Entities
{
    public class SaidaProduto : Entity, IAggregateRoot
    {

        public SaidaProduto(Guid id, string numero, DateTime data, int quantidade)
        {
            Id = id;
            Numero = numero;
            Data = data;
            Quantidade = quantidade;
        }
        
        public SaidaProduto() { }
        public string Numero { get; set; }
        public DateTime Data { get; set; }
        public int Quantidade { get; set; }
        public int IdProduto { get; set; }
        public virtual Produto Produtos { get; set; }


        
    }
}
