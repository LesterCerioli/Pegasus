using FluentValidation;
using Galax.Solution.Domain.Commands.MarcaProdutoCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.MarcaProdutoValidations
{
    public abstract class MarcaProdutoValidation<T> : AbstractValidator<T> where T : MarcaProdutoCommand
    {
        protected void ValidateNome() 
        {
            RuleFor(j => j.Nome)
                .NotEmpty().WithMessage("Por gentileza, informe o Nome da Marca do Produto.")
                .Length(2, 100).WithMessage("O Nome da Marca do Produto deve possuir entre 2 e 100 caracteres.");
        }

        protected void ValidateId()
        {
            RuleFor(j => j.Id)
                .NotEqual(Guid.Empty);
        }

    }
}

