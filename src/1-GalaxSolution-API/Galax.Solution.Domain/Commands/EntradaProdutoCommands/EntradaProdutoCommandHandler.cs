using System;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation.Results;
using Galax.Solution.Domain.Entities;
using Galax.Solution.Domain.Events.EntradaProdutoEvents;
using Galax.Solution.Domain.Interfaces;
using MediatR;
using NetDevPack.Messaging;

namespace Galax.Solution.Domain.Commands.EntradaProdutoCommands
{
    public class EntradaProdutoCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewEntradaProdutoCommand, ValidationResult>,
        IRequestHandler<UpdateEntradaProdutoCommand, ValidationResult>,
        IRequestHandler<RemoveEntradaProdutoCommand, ValidationResult>

    {
        private readonly IEntradaProdutoRepository _entradaProdutoRepository;

        public EntradaProdutoCommandHandler(IEntradaProdutoRepository entradaProdutoRepository)
        {
            _entradaProdutoRepository = entradaProdutoRepository;
        }

        public async Task<ValidationResult> Handle(RegisterNewEntradaProdutoCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;


            var entradaProduto = new ProductInput(Guid.NewGuid(), message.Numero, message.Data, message.Quantidade);

            var entradaProduto = new EntradaProduto(Guid.NewGuid(), message.Numero, message.Data, message.Quantidade);


            if (await _entradaProdutoRepository.GetByNumero(entradaProduto.Numero) != null)
            {
                AddError("O Número já foi enviado.");
                return ValidationResult;

            }
            entradaProduto.AddDomainEvent(new EntradaProdutoRegisteredEvent(entradaProduto.Id, message.Numero, entradaProduto.Data, entradaProduto.Quantidade));
            _entradaProdutoRepository.Add(entradaProduto);
            return await Commit(_entradaProdutoRepository.UnitOfWork);

        }

        public async Task<ValidationResult> Handle(UpdateEntradaProdutoCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var entradaProduto = new ProductInput(message.Id, message.Numero, message.Data, message.Quantidade);

            var entradaProduto = new EntradaProduto(message.Id, message.Numero, message.Data, message.Quantidade);

            var existingEntradaProduto = await _entradaProdutoRepository.GetByNumero(entradaProduto.Numero);

            if (existingEntradaProduto != null && existingEntradaProduto.Id != entradaProduto.Id)
            {
                if (!existingEntradaProduto.Equals(entradaProduto))
                {
                    AddError(" O número da entrada do produto já foi enviado.");
                    return ValidationResult;
                }
            }

            entradaProduto.AddDomainEvent(new EntradaProdutoUpdatedEvent(entradaProduto.Id, message.Numero, entradaProduto.Data, entradaProduto.Quantidade));

            _entradaProdutoRepository.Update(entradaProduto);

            return await Commit(_entradaProdutoRepository.UnitOfWork);
        }




        public async Task<ValidationResult> Handle(RemoveEntradaProdutoCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var entradaProduto = await _entradaProdutoRepository.GetById(message.Id);

            if (entradaProduto is null)
            {
                AddError("Esse número não existe.");
                return ValidationResult;

            }

            entradaProduto.AddDomainEvent(new EntradaProdutoRemovedEvent(message.Id));

            _entradaProdutoRepository.Remove(entradaProduto);

            return await Commit(_entradaProdutoRepository.UnitOfWork);

        }


        public void Dispose()
        {
            _entradaProdutoRepository.Dispose();
        }

    }  
}
