using System;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation.Results;
using Galax.Solution.Domain.Entities;
using Galax.Solution.Domain.Events.CidadeEvent;
using Galax.Solution.Domain.Interfaces;
using MediatR;
using NetDevPack.Messaging;

namespace Galax.Solution.Domain.Commands.CidadeCommands
{
    public class CidadeCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewCidadeCommand, ValidationResult>,
        IRequestHandler<UpdateCidadeCommand, ValidationResult>,
        IRequestHandler<RemoveCidadeCommand, ValidationResult>





    {
        private readonly ICidadeRepository _cidadeRepository;

        
        //using MediatoR
        public CidadeCommandHandler(ICidadeRepository cidadeRepository)
        {
            _cidadeRepository = cidadeRepository;
        }

        public async Task<ValidationResult> Handle(RegisterNewCidadeCommand message, CancellationToken cancellationToken)
        {
            if(!message.IsValid()) return message.ValidationResult;
            
            var cidade = new Cidade(Guid.NewGuid(), message.Nome, message.Ativo);

            if (await _cidadeRepository.GetByNome(cidade.Nome)!= null)
            {
                AddError("O nome da Cidade já foi enviado.");
                return ValidationResult;
            }
            cidade.AddDomainEvent(new CidadeRegisteredEvent(cidade.Id, cidade.Nome, cidade.Ativo));
            _cidadeRepository.Add(cidade);
            return await Commit(_cidadeRepository.UnitOfWork);

        }

        public async Task<ValidationResult> Handle(UpdateCidadeCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;
            var cidade = new Cidade(message.Id, message.Nome, message.Ativo);
            var existingCidade = await _cidadeRepository.GetByNome(cidade.Nome);

            if (existingCidade != null && existingCidade.Id != cidade.Id)
            {
               if (!existingCidade.Equals(cidade))
               {
                   AddError(" O nome da Cidade já foi enviado.");
                   return ValidationResult;
               }
            }

            cidade.AddDomainEvent(new CidadeUpdatedEvent(cidade.Id, cidade.Nome));

            _cidadeRepository.Update(cidade);

            return await Commit(_cidadeRepository.UnitOfWork);
        }     
        
             
        public async Task<ValidationResult> Handle(RemoveCidadeCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var cidade = await _cidadeRepository.GetById(message.Id);

            if (cidade is null)
            {
                AddError("Essa Cidade não existe.");
                return ValidationResult;
            }

            cidade.AddDomainEvent(new CidadeRemovedEvent(message.Id));

            _cidadeRepository.Remove(cidade);

            return await Commit(_cidadeRepository.UnitOfWork);

        }

        public void Dispose()
        {
            _cidadeRepository.Dispose();
        }
    }
        
}