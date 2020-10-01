using FluentValidation;
using Galax.Solution.Domain.Commands.UnidadeMedidaCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.UnidadeMedidaValidations
{
    public abstract class UnidadeMedidaValidation<T> : AbstractValidator<T> where T : UnidadeMedidaCommand
    {
        protected void ValidateNome()
        {
            RuleFor(o => o.Nome)
                .NotEmpty().WithMessage("Por gentileza, informe o Nome da Unidade de Medida.")
                .Length(2, 100).WithMessage("O Nome da Unidade de Medida deve possuir entre 2 e 100 caracteres.");
        }

        protected void ValidateSigla()
        {
            RuleFor(o => o.Sigla)
                .NotEmpty().WithMessage("Por gentileza, informe a Sigla da Unidade de Medida.")
                .Length(2, 100).WithMessage("A Sigla da Unidade de Medida deve possuir entre 2 e 100 caracteres.");
        }

        protected void ValidateId() 
        {
            RuleFor(o => o.Id)
                .NotEqual(Guid.Empty);
        }


    }
}
