using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class Fornecedor : Entity, IAggregateRoot
    {

        public Fornecedor(Guid id, string nomeFantasia, string razaoSocial, string telefone, string contato, string logradouro, string numero, string complemento, string cep, bool ativo)
        {
            Id = id;
            NomeFantasia = nomeFantasia;
            RazaoSocial = razaoSocial;
            
            Telefone = telefone;
            Contato = contato;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Cep = cep;
            Ativo = ativo;
        }
               
        
        protected Fornecedor() { }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public Tipo Tipos { get; set; }
        public string Telefone { get; set; }
        public string Contato { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public int PaisId { get; set; }
        public virtual Pais Pais { get; set; }
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }
        public int CidadeId { get; set; }
        public virtual Cidade Cidade { get; set; }
        public bool Ativo { get; set; }
        public int CNPJId {get; set;}
        public virtual CNPJ CNPJ {get; set;}

                
    }
}
