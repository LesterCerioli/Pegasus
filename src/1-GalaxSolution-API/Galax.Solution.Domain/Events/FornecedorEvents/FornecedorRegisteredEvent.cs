using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Events.FornecedorEvents
{
    public class FornecedorRegisteredEvent : Event 
    {
        public  FornecedorRegisteredEvent(Guid id, string nomeFantasia, string razaoSocial, string telefone, string contato, string logradouro, string numero, string complemento, string cep, bool ativo)
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
            AggregateId = id;

        }

        public Guid Id { get; set; }
        public string NomeFantasia { get; private set; }
        public string RazaoSocial { get; private set; }
        public string Telefone { get; private set; }
        public string Contato { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Cep { get; private set; }
        public bool Ativo { get; private set; }


    }
}

