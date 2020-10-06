using FluentValidation.Results;
using Galax.Solution.Domain.Entities;
using Galax.Solution.Domain.Events.MarcaProdutoEvents;
using Galax.Solution.Domain.Interfaces;
using MediatR;
using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Commands.MarcaProdutoCommands
{
    public class MarcaProdutoCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewMarcaProdutoCommand, ValidationResult>,
        IRequestHandler<UpdateMarcaProdutoCommand, ValidationResult>,
        IRequestHandler<RemoveMarcaProdutoCommand, ValidationResult>

    {
        private readonly IMarcaProdutorRepository _marcaProdutorRepository;

        public MarcaProdutoCommandHandler(IMarcaProdutorRepository marcaProdutorRepository) 
        {
            _marcaProdutorRepository = marcaProdutorRepository;

        }

        public async Task<ValidationResult> Handle(RegisterNewMarcaProdutoCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var marcaProduto = new ProductBrand(Guid.NewGuid(), message.Nome, message.Ativo);

            if (await _marcaProdutorRepository.GetByNome(marcaProduto.Nome) != null)
            {
                AddError("O Nome da Marca do Produto já foi enviado.");
                return ValidationResult;

            }

            marcaProduto.AddDomainEvent(new MarcaProdutoRegisteredEvent(marcaProduto.Id, marcaProduto.Nome, marcaProduto.Ativo));
            _marcaProdutorRepository.Add(marcaProduto);
            return await Commit(_marcaProdutorRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateMarcaProdutoCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;
            var marcaProduto = new ProductBrand(message.Id, message.Nome, message.Ativo);
            var existingMarcaProduto = await _marcaProdutorRepository.GetByNome(marcaProduto.Nome);

            if (existingMarcaProduto != null && existingMarcaProduto.Id != marcaProduto.Id)
            {
                if (!existingMarcaProduto.Equals(marcaProduto))
                {
                    AddError("O Nome da Marca do Produto já foi enviado.");
                    return ValidationResult;
                }


            }
            marcaProduto.AddDomainEvent(new MarcaProdutoUpdatedEvent(marcaProduto.Id, marcaProduto.Nome, marcaProduto.Ativo));

            _marcaProdutorRepository.Update(marcaProduto);

            return await Commit(_marcaProdutorRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(RemoveMarcaProdutoCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var marcaProduto = await _marcaProdutorRepository.GetById(message.Id);

            if (marcaProduto is null)
            {
                AddError("Essa Marca de Produto não existe.");
                return ValidationResult;

            }

            marcaProduto.AddDomainEvent(new MarcaProdutoRemovedEvent(marcaProduto.Id));

            _marcaProdutorRepository.Remove(marcaProduto);

            return await Commit(_marcaProdutorRepository.UnitOfWork);
        }

        public void Dipose() 
        {
            _marcaProdutorRepository.Dispose();
        }
    }
}
