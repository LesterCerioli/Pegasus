using FluentValidation.Results;
using Galax.Solution.Domain.Entities;
using Galax.Solution.Domain.Events.LocalArmazenamentoEvents;
using Galax.Solution.Domain.Interfaces;
using MediatR;
using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Commands.LocalArmazenamentoCommands
{
    public class LocalArmazenamentoCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewLocalArmazenamentoCommand, ValidationResult>,
        IRequestHandler<UpdateLocalArmazenamentoCommand, ValidationResult>,
        IRequestHandler<RemoveLocalArmazenamentoCommand, ValidationResult>

    {
        private readonly ILocalStorageRepository _localArmazenamentoRepository;

        public LocalArmazenamentoCommandHandler(ILocalStorageRepository localArmazenamentoRepository) 
        {
            _localArmazenamentoRepository = localArmazenamentoRepository;
        }

        public async Task<ValidationResult> Handle(RegisterNewLocalArmazenamentoCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var localArmazenamento = new LocalStorage (Guid.NewGuid(), message.Nome, message.Ativo);

            if (await _localArmazenamentoRepository.GetByNome(localArmazenamento.Nome) != null) 
            {
                AddError("O Nome do Local de Armazanamento já foi enviado.");
                return ValidationResult;

            }

            localArmazenamento.AddDomainEvent(new LocalStorageRegisteredEvent(localArmazenamento.Id, localArmazenamento.Nome, localArmazenamento.Ativo));
            _localArmazenamentoRepository.Add(localArmazenamento);
            return await Commit(_localArmazenamentoRepository.UnitOfWork);


        }

        public async Task<ValidationResult> Handle(UpdateLocalArmazenamentoCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;
            var localArmazenamento = new LocalStorage(message.Id, message.Nome, message.Ativo);
            var existingLocalArmazenamento = await _localArmazenamentoRepository.GetByNome(localArmazenamento.Nome);

            if (existingLocalArmazenamento != null && existingLocalArmazenamento.Id != localArmazenamento.Id) 
            {
               if (!existingLocalArmazenamento.Equals(localArmazenamento)) 
               {
                   AddError("O Nome do Local de Armazenamento já foi enviado.");
                   return ValidationResult;
               }

                                
            }
            localArmazenamento.AddDomainEvent(new LocalStorageUpdatedEvent(localArmazenamento.Id, localArmazenamento.Nome, localArmazenamento.Ativo));

            _localArmazenamentoRepository.Update(localArmazenamento);

            return await Commit(_localArmazenamentoRepository.UnitOfWork);

        }

        public async Task<ValidationResult> Handle(RemoveLocalArmazenamentoCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var localArmazenamento = await _localArmazenamentoRepository.GetById(message.Id);

            if (localArmazenamento is null) 
            {
                AddError("Esse Local de Armazenamento não existe.");
                return ValidationResult;

            }

            localArmazenamento.AddDomainEvent(new LocalStorageRemovedEvent(localArmazenamento.Id));

            _localArmazenamentoRepository.Remove(localArmazenamento);

            return await Commit(_localArmazenamentoRepository.UnitOfWork); 

        }

        public void Dispose() 
        {
            _localArmazenamentoRepository.Dispose(); 

        }
    }
}
