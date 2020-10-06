using System;
using FluentValidation;


namespace Galax.Solution.Domain.Commands.Validations.CityValidations
{
    public abstract class CityValidation<T> : AbstractValidator<T> where T : CityCommand
    {
        protected void ValidateNome()
        {
            RuleFor(a => a.Name)
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