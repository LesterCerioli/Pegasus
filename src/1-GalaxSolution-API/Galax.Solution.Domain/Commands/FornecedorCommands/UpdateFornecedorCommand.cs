using Galax.Solution.Domain.Commands.FornecedorCommandsS;
using Galax.Solution.Domain.Commands.Validations.FornecedorValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.FornecedorCommands
{
    public class UpdateFornecedorCommand : FornecedorCommand 
    {
        public UpdateFornecedorCommand(Guid id,string nomeFantasia, string razaoSocial, string telefone, string contato, string logradouro, string numero, string complemento, string cep, bool ativo) 
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

        public override bool IsValid()
        {
            ValidationResult = new UpdateFornecedorCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }


    }
}
