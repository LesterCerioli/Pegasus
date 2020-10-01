using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class Perfil : Entity, IAggregateRoot
    {

        public Perfil(Guid id, string nome, bool ativo)
        {
            Id = id;
            Nome = nome;
            Ativo = ativo;
        }
        
        protected Perfil() { }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public virtual List<UsuarioEstoque> Usuarios { get; set; }



        
    }
}
