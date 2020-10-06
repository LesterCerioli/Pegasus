using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class Pais : Entity, IAggregateRoot
    {

        public Pais(Guid id, string nome, string codigo, bool ativo)
        {
            Id = id;
            Nome = nome;
            Codigo = codigo;
            Ativo = ativo;
        }
        
        
        protected Pais() { }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public bool Ativo { get; set; }
        public virtual List<Estado> Estados { get; set; }
        public virtual List<Cidade> Cidades { get; set; }
        public virtual ICollection<UsuarioEstoque> UsuariosEstoque { get; set; }
        public virtual ICollection<Cidade> Cidade { get; set; }
        public virtual ICollection<Estado> Estado { get; set; }








    }
}
