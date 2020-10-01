using FluentValidation.Results;
using Galax.Solution.Domain.Entities;
using Galax.Solution.Domain.Events.CPFEvents;
using Galax.Solution.Domain.Interfaces;
using MediatR;
using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Commands.CPFCommands
{
    public class CPFCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewCPFCommand, ValidationResult>,
        IRequestHandler<UpdateCPFCommand, ValidationResult>,
        IRequestHandler<RemoveCPFCommand, ValidationResult>

    {
        private readonly ICPFRepository _cPFRepository;

        public CPFCommandHandler(ICPFRepository cPFRepository) 
        {
            _cPFRepository = cPFRepository;

        }

        public async Task<ValidationResult> Handle(RegisterNewCPFCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var cpf = new CPF(Guid.NewGuid(), message.NumCPF);

            if (await _cPFRepository.GetByNumCPF(cpf.NumCPF)!= null) 
            {
               
                AddError("O número do CPF já foi enviado.");
                return ValidationResult;

            }

            cpf.AddDomainEvent(new CPFRegisteredEvent(cpf.Id, cpf.NumCPF));
            _cPFRepository.Add(cpf);
            return await Commit(_cPFRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateCPFCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;
            var cpf = new CPF(message.Id, message.NumCPF);
            var existingCPF = await _cPFRepository.GetByNumCPF(cpf.NumCPF);

            if (existingCPF != null && existingCPF.Id != cpf.Id)
            {
                if (!existingCPF.Equals(cpf))
                {
                    AddError(" O número do CPF já foi enviado.");
                    return ValidationResult;
                }
            }

            cpf.AddDomainEvent(new CPFUpdatedEvent(cpf.Id, cpf.NumCPF));

            _cPFRepository.Update(cpf);

            return await Commit(_cPFRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(RemoveCPFCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var cpf = await _cPFRepository.GetById(message.Id);

            if (cpf is null)
            {
                AddError("Esse CPF não existe.");
                return ValidationResult;
            }

            cpf.AddDomainEvent(new CPFRemovedEvent(message.Id));

            _cPFRepository.Remove(cpf);

            return await Commit(_cPFRepository.UnitOfWork);

        }

        public void Dispose()
        {
            _cPFRepository.Dispose();
        }
    }

}