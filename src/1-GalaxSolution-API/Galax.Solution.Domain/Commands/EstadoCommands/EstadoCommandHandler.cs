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

namespace Galax.Solution.Domain.Commands.EstadoCommands
{
    public class EstadoCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewEstadoCommand, ValidationResult>,
        IRequestHandler<UpdateEstadoCommand, ValidationResult>,
        IRequestHandler<RemoveEstadoCommand, ValidationResult>

    {
        private readonly IEstadoRepository _estadoRepository;

        public EstadoCommandHandler(IEstadoRepository estadoRepository) 
        {
            _estadoRepository = estadoRepository;
        }

        public async  Task<ValidationResult> Handle(RegisterNewEstadoCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

<<<<<<< HEAD
            var estado = new State(Guid.NewGuid(), message.Nome, message.UF, message.Ativo);
=======
            var estado = new Estado(Guid.NewGuid(), message.Nome, message.UF, message.Ativo);
>>>>>>> master

            if (await _estadoRepository.GetByNome(estado.Nome) != null)
            {
                AddError("O nome do Estado já foi enviado.");
                return ValidationResult;
            }
            estado.AddDomainEvent(new EstadoRegisteredEvent(estado.Id, estado.Nome, estado.UF,  estado.Ativo));
            _estadoRepository.Add(estado);
            return await Commit(_estadoRepository.UnitOfWork);
        }

        public async  Task<ValidationResult> Handle(UpdateEstadoCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;
<<<<<<< HEAD
            var estado = new State(message.Id, message.Nome, message.UF,  message.Ativo);
=======
            var estado = new Estado(message.Id, message.Nome, message.UF,  message.Ativo);
>>>>>>> master
            var existingEstado = await _estadoRepository.GetByNome(estado.Nome);

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