using FluentValidation.Results;
using Galax.Solution.Domain.Entities;
using Galax.Solution.Domain.Events.EstadoEvents;
using Galax.Solution.Domain.Interfaces;
using MediatR;
using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Commands.StateCommands
{
    public class StateCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewStateCommand, ValidationResult>,
        IRequestHandler<UpdateStateCommand, ValidationResult>,
        IRequestHandler<RemoveStateCommand, ValidationResult>

    {
        private readonly IStateRepository _stateRepository;

        public StateCommandHandler(IStateRepository stateRepository) 
        {
            _stateRepository = stateRepository;
        }

        public async  Task<ValidationResult> Handle(RegisterNewStateCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;


            var state = new State(Guid.NewGuid(), message.Name, message.UF, message.Ativo);

            var state = new State(Guid.NewGuid(), message.Nome, message.UF, message.Ativo);


            if (await _stateRepository.GetByNome(state.Name) != null)
            {
                AddError("O nome do Estado já foi enviado.");
                return ValidationResult;
            }
            state.AddDomainEvent(new StateRegisteredEvent(state.Id, state.Name, state.UF,  state.Ativo));
            _stateRepository.Add(state);
            return await Commit(_stateRepository.UnitOfWork);
        }

        public async  Task<ValidationResult> Handle(UpdateStateCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var state = new State(message.Id, message.Name, message.UF,  message.Actived);

            var state = new State(message.Id, message.Name, message.UF,  message.Actived);

            var existingState = await _stateRepository.GetByName(state.Name);

            if (existingEstado != null && existingEstado.Id != estado.Id)
            {
                if (!existingEstado.Equals(estado))
                {
                    AddError(" O nome do Estado já foi enviado.");
                    return ValidationResult;
                }
            }

            estado.AddDomainEvent(new EstadoUpdatedEvent(estado.Id, estado.Nome, message.UF, message.Ativo));

            _estadoRepository.Update(estado);

            return await Commit(_estadoRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(RemoveEstadoCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var estado = await _estadoRepository.GetById(message.Id);

            if (estado is null)
            {
                AddError("Esse Estado não existe.");
                return ValidationResult;
            }

            estado.AddDomainEvent(new EstadoRemovedEvent(message.Id));

            _estadoRepository.Remove(estado);

            return await Commit(_estadoRepository.UnitOfWork);

        }

        public void Dispose()
        {
            _estadoRepository.Dispose();
        }
    }

}