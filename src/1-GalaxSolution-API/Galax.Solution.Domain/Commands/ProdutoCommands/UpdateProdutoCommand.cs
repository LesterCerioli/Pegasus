using Galax.Solution.Domain.Commands.Validations.ProdutoValidations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Commands.ProdutoCommands
{
    public class UpdateProdutoCommand : ProdutoCommand
    {
        public UpdateProdutoCommand(Guid id, string nome, string codigo, decimal precoCusto, decimal precoVenda, int quantEstoque, bool ativo, string imagem) 
        {
            Id = id;
            Nome = nome;
            Codigo = codigo;
            PrecoCusto = precoCusto;
            PrecoVenda = precoVenda;
            QuantEstoque = quantEstoque;
            Ativo = ativo;
            Imagem = imagem;

        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateProdutoCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
