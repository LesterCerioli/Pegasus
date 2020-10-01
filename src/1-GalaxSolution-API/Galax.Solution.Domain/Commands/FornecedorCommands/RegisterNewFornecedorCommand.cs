using Galax.Solution.Domain.Commands.FornecedorCommandsS;
using Galax.Solution.Domain.Commands.Validations.FornecedorValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.FornecedorCommands
{
    public class RegisterNewFornecedorCommand : FornecedorCommand
    {
        public RegisterNewFornecedorCommand(string nomeFantasia, string razaoSocial, string telefone, string contato, string logradouro, string numero, string complemento, string cep, bool ativo) 
        {
            NomeFantasia = nomeFantasia;
            RazaoSocial = razaoSocial;
            Telefone = telefone;
            Contato = contato;
            Complemento = complemento;
            Cep = cep;
            Ativo = ativo;
                  
        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewFornecedorCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
