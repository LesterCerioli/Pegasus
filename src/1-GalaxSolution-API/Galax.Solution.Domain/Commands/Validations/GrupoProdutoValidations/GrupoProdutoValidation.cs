using FluentValidation;
using Galax.Solution.Domain.Commands.GrupoProdutoCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.GrupoProdutoValidations
{
    public abstract class GrupoProdutoValidation<T> : AbstractValidator<T> where T : GrupoProdutoCommand
    {
        protected void ValidateNome() 
        {
            RuleFor(g => g. Nome)
                .NotEmpty().WithMessage("Por gentileza, informe o Nome do Grupo de Produto.")
                .Length(2, 100).WithMessage("O nome deve possuir entre 2 e 100 caracteres.");
        }
        protected void ValidateId()
        {
            RuleFor(g => g.Id)
                .NotEqual(Guid.Empty);
        }

    }
}
