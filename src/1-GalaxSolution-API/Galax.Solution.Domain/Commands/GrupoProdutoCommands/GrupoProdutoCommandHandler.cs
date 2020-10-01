using FluentValidation.Results;
using Galax.Solution.Domain.Entities;
using Galax.Solution.Domain.Events.GrupoProdutoEvents;
using Galax.Solution.Domain.Interfaces;
using MediatR;
using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Commands.GrupoProdutoCommands
{
    public class GrupoProdutoCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewGrupoProdutoCommand, ValidationResult>,
        IRequestHandler<UpdateGrupoProdutoCommand, ValidationResult>,
        IRequestHandler<RemoveGrupoProdutoCommand, ValidationResult>

    {
        private readonly IGrupoProdutoRepository _grupoProdutoRepository;
        public GrupoProdutoCommandHandler(IGrupoProdutoRepository grupoProdutoRepository) 
        {
            _grupoProdutoRepository = grupoProdutoRepository;
        }
        public async Task<ValidationResult> Handle(RegisterNewGrupoProdutoCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var grupoProduto = new GrupoProduto(Guid.NewGuid(), message.Nome, message.Ativo);

            if (await _grupoProdutoRepository.GetByNome(grupoProduto.Nome) != null)
            {
                AddError("O número do Grupo de Produto já foi enviado.");
                return ValidationResult;
            }

            grupoProduto.AddDomainEvent(new GrupoProdutoRegisteredEvent(grupoProduto.Id, grupoProduto.Nome, grupoProduto.Ativo));
            _grupoProdutoRepository.Add(grupoProduto);
            return await Commit(_grupoProdutoRepository.UnitOfWork);
        }

        public async  Task<ValidationResult> Handle(UpdateGrupoProdutoCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;
            var grupoProduto = new GrupoProduto(message.Id, message.Nome, message.Ativo);
            var existingGrupoProduto = await _grupoProdutoRepository.GetByNome(grupoProduto.Nome);

            if (existingGrupoProduto != null && existingGrupoProduto.Id != grupoProduto.Id)
            {
                if (!existingGrupoProduto.Equals(grupoProduto))
                {
                    AddError(" O nome do Grupo de Produto já foi enviado.");
                    return ValidationResult;
                }
            }

            grupoProduto.AddDomainEvent(new GrupoProdutoUpdatedEvent(grupoProduto.Id, grupoProduto.Nome, grupoProduto.Ativo));

            _grupoProdutoRepository.Update(grupoProduto);

            return await Commit(_grupoProdutoRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(RemoveGrupoProdutoCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var grupoProduto = await _grupoProdutoRepository.GetById(message.Id);

            if (grupoProduto is null)
            {
                AddError("Esse Grupo de Produto não existe.");
                return ValidationResult;
            }

            grupoProduto.AddDomainEvent(new GrupoProdutoRemovedEvent(message.Id));

            _grupoProdutoRepository.Remove(grupoProduto);

            return await Commit(_grupoProdutoRepository.UnitOfWork);

        }

        public void Dispose()
        {
            _grupoProdutoRepository.Dispose();
        }
    }

}

