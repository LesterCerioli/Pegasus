
using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Entities
{
    public class Cliente : Entity, IAggregateRoot
    {
        public Cliente(string nome, string meioNome, string sobreNome, string email)
        {
            Nome = nome;
            MeioNome = meioNome;
            SobreNome = sobreNome;
            Email = email;
        }

        protected Cliente() { }
        public string Nome { get; private set; }
        public string MeioNome { get; private set; }
        public string SobreNome { get; private set; }
        public string Email { get; private set; }
    }
    

}
