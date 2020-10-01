using FluentValidation;
using Galax.Solution.Domain.Commands.FornecedorCommandsS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.FornecedorValidations
{
    public abstract class FornecedorValidation<T> :  AbstractValidator<T> where T : FornecedorCommand
    {
        protected void ValidateNomeFantasia()
        {
            RuleFor(f => f.NomeFantasia)
                .NotEmpty().WithMessage("Por gentileza, informe o Nome Fantasia.")
                .Length(2, 100).WithMessage("O nome deve possuir entre 2 e 100 caracteres.");

        }

        protected void ValidateRazaoSocial()
        {
            RuleFor(f => f.RazaoSocial)
                .NotEmpty().WithMessage("Por gentileza, informe o número da Razão Social.")
                .Length(2, 100).WithMessage("O número deve possuir entre 2 e 100 caracteres.");

        }

        protected void ValidateTelefone()
        {
            RuleFor(f => f.Telefone)
                .NotEmpty().WithMessage("Por gentileza, informe o número de telefone.")
                .Length(12, 15).WithMessage("O número do Telefone deve possuir entre 12 e 15 caracteres.");

        }

        protected void ValidateContato()
        {
            RuleFor(f => f.Contato)
                .NotEmpty().WithMessage("Por gentileza, informe o número de Contato.")
                .Length(2, 100).WithMessage("O número de Contato deve possuir entre 2 e 100 caracteres.");

        }

        protected void ValidateLogradouro()
        {
            RuleFor(f => f.Logradouro)
                .NotEmpty().WithMessage("Por gentileza, informe o Logradouro.") 
                .Length(2, 100).WithMessage("O número deve possuir entre 2 e 100 caracteres.");

        }

        protected void ValidateNumero()
        {
            RuleFor(f => f.Numero)
                .NotEmpty().WithMessage("Por gentileza, informe o número do seu endereço.")
                .Length(2, 50).WithMessage("O número deve possuir entre 2 e 50 caracteres.");

        }

        protected void ValidateComplemento()
        {
            RuleFor(f => f.Complemento)
                .NotEmpty().WithMessage("Por gentileza, informe o Complemento.")
                .Length(2, 100).WithMessage("O Complemento deve possuir entre 2 e 100 caracteres.");

        }

        protected void ValidateCep()
        {
            RuleFor(f => f.Cep)
                .NotEmpty().WithMessage("Por gentileza, informe o número do Cep.")
                .Length(2, 20).WithMessage("O número deve possuir entre 2 e 20 caracteres.");

        }

        protected void ValidateId()
        {
            RuleFor(e => e.Id)
                .NotEqual(Guid.Empty);
        }

    }
}
