using FluentValidation;
using FluentValidation.Validators;
using Galax.Solution.Domain.Commands.PerfilCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.PerfilValidations
{
    public abstract class PerfilValidation<T> : AbstractValidator<T> where T : PerfilCommand
    {
        protected void ValidateNome() 
        {
            RuleFor(l => l.Nome)
                .NotEmpty().WithMessage("Por gentileza, informe o Nome do Perfil.")
                .Length(2, 100).WithMessage("O Nome do Perfil deve possuir entre 2 e 100 caracteres.");
        }

        protected void ValidateId()
        {
            RuleFor(l => l.Id)
                .NotEqual(Guid.Empty);
        }


    }
}
