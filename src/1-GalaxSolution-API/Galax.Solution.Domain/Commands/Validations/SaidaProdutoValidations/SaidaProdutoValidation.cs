using FluentValidation;
using Galax.Solution.Domain.Commands.SaidaProdutoCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.SaidaProdutoValidations
{
    public abstract class SaidaProdutoValidation<T> : AbstractValidator<T> where T : SaidaProdutoCommand
    {
        protected void ValidateNumero()
        {
            RuleFor(n => n.Numero)
                .NotEmpty().WithMessage("Por gentileza, informe o Número da Saída do Produto.")
                .Length(2, 100).WithMessage("O Número da Saída do Produto Perfil deve possuir entre 2 e 100 caracteres.");
        }

        protected void ValidateData()
        {
            RuleFor(n => n.Data)
                .NotEmpty().WithMessage("Por gentileza, informe o Data da Saída do Produto.");
        }

        protected void ValidateQuantidade()
        {
            RuleFor(n => n.Quantidade)
                .NotEmpty().WithMessage("Por gentileza, informe a Quantidade da Saída do Produto.");
        }

        protected void ValidateId()
        {
            RuleFor(n => n.Id)
                .NotEqual(Guid.Empty);
        }

    }
}
