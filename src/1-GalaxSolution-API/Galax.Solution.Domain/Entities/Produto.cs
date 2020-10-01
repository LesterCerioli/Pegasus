using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
       

    public class Produto : Entity, IAggregateRoot
    {
        
        public Produto(Guid id, string nome, string codigo, decimal precoCusto, decimal precoVenda, int quantEstoque, bool ativo, string imagem )
        {
            Id = id;
            Nome = nome;
            Codigo = codigo;
            PrecoCusto = precoCusto;
            PrecoVenda = precoVenda;
            QuantEstoque = quantEstoque;
            Ativo = ativo;
            Imagem = imagem;
        }
        
        protected Produto() { }
        
        public string Codigo { get; set; }
        public string Nome { get; set; }

        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; }
        public int QuantEstoque { get; set; }
        public int UnidadeMedidaId { get; set; }
        public virtual UnidadeMedida UnidadeMedidas { get; set; }
        public int IdGrupo { get; set; }
        public virtual GrupoProduto Grupos { get; set; }
        public int MarcaId { get; set; }
        public virtual MarcaProduto Marcas { get; set; }
        public int FornecedorId { get; set; }
        public virtual Fornecedor Fornecedores { get; set; }
        public int LocalArmazenamentoId { get; set; }
        public virtual LocalArmazenamento LocalArmazenamentos { get; set; }
        public bool Ativo { get; set; }
        public string Imagem { get; set; }



        
    }
}
