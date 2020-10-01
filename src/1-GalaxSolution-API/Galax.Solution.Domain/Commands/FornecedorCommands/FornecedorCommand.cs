using System;
using Galax.Solution.Domain.Entities;
using NetDevPack.Messaging;

namespace Galax.Solution.Domain.Commands.FornecedorCommandsS
{
    public abstract class FornecedorCommand : Command
    {
        public Guid Id { get; protected set; }
        public string NomeFantasia { get; protected set; }
        public string RazaoSocial { get; protected set; }        
        public string Telefone { get; protected set; }
        public string Contato { get; protected set; }
        public string Logradouro { get; protected set; }
        public string Numero { get; protected set; }
        public string Complemento { get; protected set; }
        public string Cep { get; protected set; }              
        public bool Ativo { get; protected set; }
        
        
    }
}