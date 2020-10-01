using Galax.Solution.Domain.Commands.ProdutoCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.ProdutoValidations
{
    public class UpdateProdutoCommandValidation : ProdutoValidation<UpdateProdutoCommand>
    {
       public UpdateProdutoCommandValidation() 
        {
            ValidateNome();
            ValidateCodigo();
            ValidatePrecoCusto();
            ValidatePrecoVenda();
            ValidateQuantEstoque();

        }
    }
}
