using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class InventarioEstoque : Entity, IAggregateRoot
    {
        public InventarioEstoque(Guid id, DateTime data, string motivo, int qtdestoque, int quantidadeinventario)
        {
            Id = id;
            Data = data;
            Motivo = motivo;
            QtdEstoque = qtdestoque;
            QuantidadeInventario = quantidadeinventario;
        }
        protected InventarioEstoque() { }
        public DateTime Data { get; set; }
        public string Motivo { get; set; }
        public int QtdEstoque{ get; set; }
        public int QuantidadeInventario { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto Produtos { get; set; }



        
    }
}
