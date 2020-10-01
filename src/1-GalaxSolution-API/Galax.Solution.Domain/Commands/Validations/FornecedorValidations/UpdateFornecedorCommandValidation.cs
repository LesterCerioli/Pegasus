using Galax.Solution.Domain.Commands.FornecedorCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.FornecedorValidations
{
    public class UpdateFornecedorCommandValidation : FornecedorValidation<UpdateFornecedorCommand>
    {
        public UpdateFornecedorCommandValidation() 
        {
            ValidateId();
            ValidateNomeFantasia();
            ValidateRazaoSocial();
            ValidateTelefone();
            ValidateContato();
            ValidateLogradouro();
            ValidateNumero();
            ValidateComplemento();
            ValidateCep();
        }
    }
}
