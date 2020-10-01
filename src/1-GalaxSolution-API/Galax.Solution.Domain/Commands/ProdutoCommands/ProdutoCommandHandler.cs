using FluentValidation.Results;
using Galax.Solution.Domain.Entities;
using Galax.Solution.Domain.Events.ProdutoEvents;
using Galax.Solution.Domain.Interfaces;
using MediatR;
using NetDevPack.Messaging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Commands.ProdutoCommands
{
    public class ProdutoCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewProdutoCommand, ValidationResult>,
        IRequestHandler<UpdateProdutoCommand, ValidationResult>,
        IRequestHandler<RemoveProdutoCommand, ValidationResult>
    {
        private readonly IProdutoRepository _produtoRepository; 
        public ProdutoCommandHandler(IProdutoRepository produtoRepository) 
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<ValidationResult> Handle(RegisterNewProdutoCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var produto = new Produto(Guid.NewGuid(), message.Nome, message.Codigo, message.PrecoCusto, message.PrecoVenda, message.QuantEstoque, message.Ativo, message.Imagem);

            if (await _produtoRepository.GetByNome(produto.Nome) != null)
            {
                AddError(" O Nome do Produto já foi enviado.");
                return ValidationResult;
            }

            produto.AddDomainEvent(new ProdutoRegisteredEvent(produto.Id, produto.Nome, produto.Codigo, produto.PrecoCusto, produto.PrecoVenda, produto.QuantEstoque, produto.Ativo, produto.Imagem));
            _produtoRepository.Add(produto);
            return await Commit(_produtoRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateProdutoCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;
            var produto = new Produto(message.Id, message.Nome, message.Codigo, message.PrecoCusto, message.PrecoVenda, message.QuantEstoque, message.Ativo, message.Imagem);
            var existingProduto = await _produtoRepository.GetByNome(produto.Nome);

            if (existingProduto != null && existingProduto.Id != produto.Id)
            {
                if (!existingProduto.Equals(produto))
                {
                    AddError("O Nomo do Produto já foi enviado.");
                    return ValidationResult;

                }
            }

            produto.AddDomainEvent(new ProdutoUpdatedEvent(produto.Id, produto.Nome, produto.Codigo, produto.PrecoCusto, produto.PrecoVenda, produto.QuantEstoque, produto.Ativo, produto.Imagem)) ;
            _produtoRepository.Update(produto);
            return await Commit(_produtoRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(RemoveProdutoCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var produto = await _produtoRepository.GetById(message.Id);

            if (produto is null)
            {
                AddError("Esse Produto não existe.");
                return ValidationResult;
            }

            produto.AddDomainEvent(new ProdutoRemovedEvent(produto.Id));

            _produtoRepository.Remove(produto);

            return await Commit(_produtoRepository.UnitOfWork);
        }

        public void Dispose()
        {
            _produtoRepository.Dispose();
        }
    }
}
