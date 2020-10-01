using Galax.Solution.Domain.Commands.ProdutoCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.ProdutoValidations
{
    public class RegisterNewProdutoCommandValidation : ProdutoValidation<RegisterNewProdutoCommand>
    {
        public RegisterNewProdutoCommandValidation() 
        {
            ValidateNome();
            ValidateCodigo();
            ValidatePrecoCusto();
            ValidatePrecoVenda();
            ValidateQuantEstoque(); 

        }
    }
}
