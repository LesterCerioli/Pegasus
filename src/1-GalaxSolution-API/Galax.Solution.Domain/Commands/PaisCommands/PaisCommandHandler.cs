using FluentValidation.Results;
using Galax.Solution.Domain.Entities;
using Galax.Solution.Domain.Events.PaisEvents;
using Galax.Solution.Domain.Interfaces;
using MediatR;
using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Commands.PaisCommands
{
    public class PaisCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewPaisCommand, ValidationResult>,
        IRequestHandler<UpdatePaisCommand, ValidationResult>,
        IRequestHandler<RemovePaisCommand, ValidationResult>
    {
        private readonly IPaisRepository _paisRepository;
        public PaisCommandHandler(IPaisRepository paisRepository) 
        {
            _paisRepository = paisRepository;
        }

        public async Task<ValidationResult> Handle(RegisterNewPaisCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var pais = new Pais(Guid.NewGuid(), message.Nome, message.Codigo, message.Ativo);

            if (await _paisRepository.GetByNome(pais.Nome)!= null) 
            {
                AddError("O Nome do País já foi enviado.");
                return ValidationResult;
            }

            pais.AddDomainEvent(new PaisRegisteredEvent(pais.Id, pais.Nome, pais.Codigo, message.Ativo));
            _paisRepository.Add(pais);
            return await Commit(_paisRepository.UnitOfWork);

        }

        public async  Task<ValidationResult> Handle(UpdatePaisCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;
            var pais = new Pais(message.Id, message.Nome,message.Codigo, message.Ativo);
            var existingPais = await _paisRepository.GetByNome(pais.Nome);

            if (existingPais != null && existingPais.Id != pais.Id)
            {
                if (!existingPais.Equals(pais))
                {
                    AddError("O Nome do País já foi enviado.");
                    return ValidationResult;

                }
            }

            pais.AddDomainEvent(new PaisUpdatedEvent(pais.Id, pais.Nome, pais.Codigo, pais.Ativo));

            _paisRepository.Update(pais);

            return await Commit(_paisRepository.UnitOfWork);
        }

        public async  Task<ValidationResult> Handle(RemovePaisCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var pais = await _paisRepository.GetById(message.Id);

            if (pais is null)
            {
                AddError("Esse País não existe.");
                return ValidationResult;

            }

            pais.AddDomainEvent(new PaisRemovedEvent(pais.Id));

            _paisRepository.Remove(pais);

            return await Commit(_paisRepository.UnitOfWork);
        }

        public void Dispose() 
        {
            _paisRepository.Dispose();
        }


        
    }
}
