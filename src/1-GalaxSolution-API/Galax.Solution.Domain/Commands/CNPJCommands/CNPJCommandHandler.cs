using System;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation.Results;
using Galax.Solution.Domain.Entities;
using Galax.Solution.Domain.Events.CNPJEvents;
using Galax.Solution.Domain.Interfaces;
using MediatR;
using NetDevPack.Messaging;

namespace Galax.Solution.Domain.Commands.CNPJCommands
{
    public class CNPJCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewCNPJCommand, ValidationResult>,
        IRequestHandler<UpdateCNPJCommand, ValidationResult>,
        IRequestHandler<RemoveCNPJCommand, ValidationResult>
    {
        private readonly ICNPJRepository _cNPJRepository;

        public CNPJCommandHandler(ICNPJRepository cNPJRepository)
        {
            _cNPJRepository = cNPJRepository;
        }
        public async Task<ValidationResult> Handle(RegisterNewCNPJCommand message, CancellationToken cancellationToken)
        {
            if(!message.IsValid()) return message.ValidationResult;

            var cnpj = new CNPJ (Guid.NewGuid(), message.NumCNPJ);

            if (await _cNPJRepository.GetByNumCNPJ(cnpj.NumCNPJ)!= null)
            {
                AddError("O número do CNPJ já foi enviado.");
                return ValidationResult;
            }

            cnpj.AddDomainEvent(new CNPJRegisteredEvent(cnpj.Id, cnpj.NumCNPJ));
            _cNPJRepository.Add(cnpj);
            return await Commit(_cNPJRepository.UnitOfWork);
        }



        public async Task<ValidationResult> Handle(UpdateCNPJCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;
            var cnpj = new CNPJ(message.Id, message.NumCNPJ);
            var existingCNPJ = await _cNPJRepository.GetByNumCNPJ(cnpj.NumCNPJ);

            if (existingCNPJ != null && existingCNPJ.Id != cnpj.Id)
            {
                if (!existingCNPJ.Equals(cnpj)) 
                {
                    AddError("O número do CNPJ já foi enviado.");
                    return ValidationResult;

                }
            }

            cnpj.AddDomainEvent(new CNPJUpdatedEvent(cnpj.Id, cnpj.NumCNPJ));

            _cNPJRepository.Update(cnpj);

            return await Commit(_cNPJRepository.UnitOfWork);

        }

        public async Task<ValidationResult> Handle(RemoveCNPJCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var cnpj = await _cNPJRepository.GetById(message.Id);

            if (cnpj is null) 
            {
                AddError("Esse CNPJ não existe.");
                return ValidationResult;

            }

            cnpj.AddDomainEvent(new CNPJRemovedEvent(cnpj.Id));

            _cNPJRepository.Remove(cnpj);

            return await Commit(_cNPJRepository.UnitOfWork);

        }
        
        public void Dispose() 
        {
            _cNPJRepository.Dispose();
        }

                    
    }
}