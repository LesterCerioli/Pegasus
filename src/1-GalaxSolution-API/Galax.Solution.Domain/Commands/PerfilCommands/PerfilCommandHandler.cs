using FluentValidation.Results;
using Galax.Solution.Domain.Entities;
using Galax.Solution.Domain.Events.PerfilEvents;
using Galax.Solution.Domain.Interfaces;
using MediatR;
using NetDevPack.Messaging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Commands.PerfilCommands
{
    public class PerfilCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewPerfilCommand, ValidationResult>,
        IRequestHandler<UpdatePerfilCommand, ValidationResult>,
        IRequestHandler<RemovePerfilCommand, ValidationResult>
    {
        private readonly IPerfilRepository _perfilRepository;
        
        public PerfilCommandHandler(IPerfilRepository perfilRepository) 
        {
            _perfilRepository = perfilRepository;

        }

        public async  Task<ValidationResult> Handle(RegisterNewPerfilCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var perfil = new StockProfile(Guid.NewGuid(), message.Nome, message.Ativo);

            if (await _perfilRepository.GetByNome(perfil.Nome)!= null) 
            {
                AddError(" O Nome do Perfil já foi enviado.");
                return ValidationResult;
            }

            perfil.AddDomainEvent(new PerfilRegisteredEvent(perfil.Id, perfil.Nome, perfil.Ativo));
            _perfilRepository.Add(perfil);
            return await Commit(_perfilRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdatePerfilCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;
            var perfil = new StockProfile(message.Id, message.Nome, message.Ativo);
            var existingPerfil = await _perfilRepository.GetByNome(perfil.Nome);

            if (existingPerfil != null && existingPerfil.Id != perfil.Id) 
            {
                if (!existingPerfil.Equals(perfil)) 
                {
                    AddError("O Nomo do Perfil já foi enviado.");
                    return ValidationResult;

                }
            }

            perfil.AddDomainEvent(new PerfilUpdatedEvent(perfil.Id, perfil.Nome, perfil.Ativo));
            _perfilRepository.Update(perfil);
            return await Commit(_perfilRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(RemovePerfilCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var perfil = await _perfilRepository.GetById(message.Id);

            if (perfil is null) 
            {
                AddError("Esse PErfil não existe.");
                return ValidationResult;
            }

            perfil.AddDomainEvent(new PerfilRemovedEvent(perfil.Id));
            
            _perfilRepository.Remove(perfil);

            return await Commit(_perfilRepository.UnitOfWork); 


        }

        public void Dispose() 
        {
            _perfilRepository.Dispose();
        }
    }
}
