using FluentValidation.Results;
using Galax.Solution.Domain.Entities;
using Galax.Solution.Domain.Events.InventarioEstoqueEvents;
using Galax.Solution.Domain.Interfaces;
using MediatR;
using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Commands.InventarioEstoqueCommands
{
    public class InventarioEstoqueCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewInventarioEstoqueCommand, ValidationResult>,
        IRequestHandler<UpdateInventarioEstoqueCommand, ValidationResult>,
        IRequestHandler<RemoveInventarioEstoqueCommand, ValidationResult>

    {
        public readonly IInventarioEstoqueRepository _inventarioEstoqueRepository;

        public InventarioEstoqueCommandHandler(IInventarioEstoqueRepository inventarioEstoqueRepository) 
        {
            _inventarioEstoqueRepository = inventarioEstoqueRepository;

        }

        public async Task<ValidationResult> Handle(RegisterNewInventarioEstoqueCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var inventarioEstoque = new InventarioEstoque(Guid.NewGuid(), message.Data, message.Motivo, message.Qtdestoque, message.QuantidadeInventario);

            if (await _inventarioEstoqueRepository.GetByData(inventarioEstoque.Data) != null) 
            {
                AddError(" A Data do Inventário do Estoque já foi enviado");
                return ValidationResult;

            }

            inventarioEstoque.AddDomainEvent(new InventarioEstoqueRegisteredEvent(inventarioEstoque.Id, inventarioEstoque.Motivo));
            _inventarioEstoqueRepository.Add(inventarioEstoque);
            return await Commit(_inventarioEstoqueRepository.UnitOfWork);

        }

        public async Task<ValidationResult> Handle(UpdateInventarioEstoqueCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;
            var inventarioEstoque = new InventarioEstoque(message.Id, message.Data, message.Motivo, message.Qtdestoque, message.QuantidadeInventario);
            var existingInventarioEstoque = await _inventarioEstoqueRepository.GetByData(inventarioEstoque.Data);

            if (existingInventarioEstoque != null && existingInventarioEstoque.Id != null) 
            {
                if (!existingInventarioEstoque.Equals(inventarioEstoque))
                {
                    AddError(" A Data do Inventário do Estoque já foi enviado");
                    return ValidationResult;

                }
            }
           

            inventarioEstoque.AddDomainEvent(new InventarioEstoqueUpdatedEvent(inventarioEstoque.Id, inventarioEstoque.Motivo));
            _inventarioEstoqueRepository.Update(inventarioEstoque);
            return await Commit(_inventarioEstoqueRepository.UnitOfWork);

        }

        public async Task<ValidationResult> Handle(RemoveInventarioEstoqueCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var inventarioEstoque = await _inventarioEstoqueRepository.GetById(message.Id);

            if (inventarioEstoque is null) 
            {
                AddError("A Data do Inventário do Estoque não existe.");
                return ValidationResult;

            }

            inventarioEstoque.AddDomainEvent(new InventarioEstoqueRemovedEvent(message.Id));

            _inventarioEstoqueRepository.Remove(inventarioEstoque);

            return await Commit(_inventarioEstoqueRepository.UnitOfWork);

        }

        public void Dispose() 
        {
            _inventarioEstoqueRepository.Dispose();
        }
    }
}
