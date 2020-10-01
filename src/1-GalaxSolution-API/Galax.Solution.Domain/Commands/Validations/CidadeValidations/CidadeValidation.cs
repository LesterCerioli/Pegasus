using System;
using FluentValidation;
using Galax.Solution.Domain.Commands.CidadeCommands;

namespace Galax.Solution.Domain.Commands.Validations.CidadeValidations
{
    public abstract class CidadeValidation<T> : AbstractValidator<T> where T : CidadeCommand
    {
        protected void ValidateNome()
        {
            RuleFor(a => a.Nome)
                .NotEmpty().WithMessage("Por gentileza, informe o nome da Cidade.")
                .Length(2, 100).WithMessage("O nome deve possuir entre 2 e 100 caracteres.");
                
        }
        protected void ValidateId()
        {
            RuleFor(a => a.Id)
                .NotEqual(Guid.Empty);
        }

    }
}