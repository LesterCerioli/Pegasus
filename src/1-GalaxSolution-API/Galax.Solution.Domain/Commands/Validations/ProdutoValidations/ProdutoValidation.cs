using FluentValidation;
using Galax.Solution.Domain.Commands.ProdutoCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.ProdutoValidations
{
    public abstract class ProdutoValidation<T>: AbstractValidator<T> where T : ProdutoCommand
    {
        protected void ValidateNome()
        {
            RuleFor(m => m.Nome)
                .NotEmpty().WithMessage("Por gentileza, informe o nome do Produto.")
                .Length(2, 100).WithMessage("O Nome do Produto deve possuir entre 2 e 100 caracteres.");

        }

        protected void ValidateCodigo()
        {
            RuleFor(m => m.Codigo)
                .NotEmpty().WithMessage("Por gentileza, informe o Código do Produto.")
                .Length(2, 100).WithMessage("O Código do Produto deve possuir entre 2 e 100 caracteres.");

        }
        protected void ValidatePrecoCusto()
        {
            RuleFor(m => m.PrecoCusto)
                .NotEmpty().WithMessage("Por gentileza, informe o Pr~ço de Custo do Produto.");

        }

        protected void ValidatePrecoVenda()
        {
            RuleFor(m => m.PrecoVenda)
                .NotEmpty().WithMessage("Por gentileza, informe o nome do Produto.");
                

        }

        protected void ValidateQuantEstoque()
        {
            RuleFor(m => m.QuantEstoque)
                .NotEmpty().WithMessage("Por gentileza, informe a Quantidade de Estoque.");
                

        }

        protected void ValidateId() 
        {
            RuleFor(m => m.Id)
                .NotEqual(Guid.Empty);
        }

        
    }
}
