using FluentValidation.Results;
using Galax.Solution.Domain.Entities;
using Galax.Solution.Domain.Events.UnidadeMedidaEvents;
using Galax.Solution.Domain.Interfaces;
using MediatR;
using Microsoft.VisualBasic;
using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Commands.UnidadeMedidaCommands
{
    public class UnidadeMedidaCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewUnidadeMedidaCommand, ValidationResult>,
        IRequestHandler<UpdateUnidadeMedidaCommand, ValidationResult>,
        IRequestHandler<RemoveUnidadeMedidaCommand, ValidationResult>

    {

        private readonly IUnidadeMedidaRepository _unidadeMedidaRepository;
        public UnidadeMedidaCommandHandler(IUnidadeMedidaRepository unidadeMedidaRepository) 
        {
            _unidadeMedidaRepository = unidadeMedidaRepository;

        }

        public async Task<ValidationResult> Handle(RegisterNewUnidadeMedidaCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var unidadeMedida = new MeasurementUnit(Guid.NewGuid(), message.Nome, message.Sigla, message.Ativo);

            if (await _unidadeMedidaRepository.GetBySigla(unidadeMedida.Sigla) != null) 
            {
                AddError("A Sigla da Unidade de Medida já foi enviada.");
                return ValidationResult;
            }
            unidadeMedida.AddDomainEvent(new UnidadeMedidaRegisteredEvent(unidadeMedida.Id, unidadeMedida.Nome, unidadeMedida.Sigla, unidadeMedida.Ativo));
            _unidadeMedidaRepository.Add(unidadeMedida);
            return await Commit(_unidadeMedidaRepository.UnitOfWork);

        }

        public async Task<ValidationResult> Handle(UpdateUnidadeMedidaCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;
            var unidadeMedida = new MeasurementUnit(message.Id, message.Nome, message.Sigla, message.Ativo);
            var existingUnidadeMedida = await _unidadeMedidaRepository.GetBySigla(unidadeMedida.Sigla);

            if (existingUnidadeMedida != null && existingUnidadeMedida.Id != unidadeMedida.Id)
            {
                if (!existingUnidadeMedida.Equals(unidadeMedida))
                {
                    AddError("A Sigla da Unidade de Medida já foi enviada.");
                    return ValidationResult;
                }
            }

            unidadeMedida.AddDomainEvent(new UnidadeMedidaUpdatedEvent(unidadeMedida.Id, unidadeMedida.Nome, unidadeMedida.Sigla, unidadeMedida.Ativo));

            _unidadeMedidaRepository.Update(unidadeMedida);

            return await Commit(_unidadeMedidaRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(RemoveUnidadeMedidaCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var unidadeMedida = await _unidadeMedidaRepository.GetById(message.Id);

            if (unidadeMedida is null)
            {
                AddError("Essa Unidade de Medida não existe.");
                return ValidationResult;

            }

            unidadeMedida.AddDomainEvent(new UnidadeMedidaRemovedEvent(message.Id));

            _unidadeMedidaRepository.Remove(unidadeMedida);

            return await Commit(_unidadeMedidaRepository.UnitOfWork);

        }

        public void Dispose() 
        {
            _unidadeMedidaRepository.Dispose();
        }
    }
}
