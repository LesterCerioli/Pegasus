using FluentValidation;
using Galax.Solution.Domain.Commands.UsuarioEstoqueCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.Validations.UsuarioEstoqueValidations
{
    public abstract class UsuarioEstoqueValidation<T> : AbstractValidator<T> where T : UsuarioEstoqueCommand
    {
        protected void ValidateLogin()
        {
            RuleFor(p => p.Login)
                .NotEmpty().WithMessage("Por gentileza, informe o Login do Usuário.")
                .Length(2, 100).WithMessage("O Login do Usuário deve possuir entre 2 e 100 caracteres.");
        }

        protected void ValidateSenha()
        {
            RuleFor(p => p.Senha)
                .NotEmpty().WithMessage("Por gentileza, informe a Senha do Usuário.")
                .Length(6, 50).WithMessage("A Senha do Usuário deve possuir entre 2 e 50 caracteres.");
        }

        protected void ValidateNome()
        {
            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("Por gentileza, informe o Nome do Usuário.")
                .Length(2, 100).WithMessage("O Nome do Usuário deve possuir entre 2 e 100 caracteres.");
        }

        protected void ValidateNomeMeio()
        {
            RuleFor(p => p.NomeMeio)
                .NotEmpty().WithMessage("Por gentileza, informe o Nome do Meio.")
                .Length(2, 100).WithMessage("O Nome do Meio deve possuir entre 2 e 100 caracteres.");
        }

        protected void ValidateSobreNome()
        {
            RuleFor(p => p.SobreNome)
                .NotEmpty().WithMessage("Por gentileza, informe o Sobrenome do Usuário.")
                .Length(2, 100).WithMessage("O Sobrenome do Usuário deve possuir entre 2 e 100 caracteres.");
        }

        protected void ValidateEmail() 
        {
            RuleFor(p => p.Email)
                .NotEmpty()
                .EmailAddress();
        }

        protected void ValidateId() 
        {
            RuleFor(p => p.Id)
                .NotEqual(Guid.Empty);
        }

    }

}
