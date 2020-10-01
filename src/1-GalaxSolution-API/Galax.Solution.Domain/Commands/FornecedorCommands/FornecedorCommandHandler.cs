using FluentValidation.Results;
using Galax.Solution.Domain.Entities;
using Galax.Solution.Domain.Events.FornecedorEvents;
using Galax.Solution.Domain.Interfaces;
using MediatR;
using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Commands.FornecedorCommands
{
    public class FornecedorCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewFornecedorCommand, ValidationResult>,
        IRequestHandler<UpdateFornecedorCommand, ValidationResult>,
        IRequestHandler<RemoveFornecedorCommand, ValidationResult>

    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedorCommandHandler(IFornecedorRepository fornecedorRepository) 
        {
            _fornecedorRepository = fornecedorRepository;
        }
        public async Task<ValidationResult> Handle(RegisterNewFornecedorCommand message, CancellationToken cancellationToken)
        {
            if(!message.IsValid()) return message.ValidationResult;

            var fornecedor = new Fornecedor(Guid.NewGuid(), message.NomeFantasia, message.RazaoSocial, message.Telefone, message.Contato, message.Logradouro, message.Numero, message.Complemento, message.Cep, message.Ativo);

            if(await _fornecedorRepository.GetByNomeFantasia(fornecedor.NomeFantasia)!= null) 
            {
                AddError(" O Nome Fantasia já foi enviado.");
                return ValidationResult;

            }
            fornecedor.AddDomainEvent(new FornecedorRegisteredEvent(fornecedor.Id, fornecedor.NomeFantasia, fornecedor.RazaoSocial, fornecedor.Telefone, fornecedor.Contato, fornecedor.Logradouro, fornecedor.Numero, fornecedor.Complemento, fornecedor.Cep, fornecedor.Ativo));
            _fornecedorRepository.Add(fornecedor);
            return await Commit(_fornecedorRepository.UnitOfWork);

        }

        public async Task<ValidationResult> Handle(UpdateFornecedorCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;
            var fornecedor = new Fornecedor(message.Id, message.NomeFantasia, message.RazaoSocial, message.Telefone, message.Contato, message.Logradouro, message.Numero, message.Complemento, message.Cep, message.Ativo);
            var existingFornecedor = await _fornecedorRepository.GetByNomeFantasia(fornecedor.NomeFantasia);

            if (existingFornecedor != null && existingFornecedor.Id != fornecedor.Id) 
            {
                if (!existingFornecedor.Equals(fornecedor)) 
                {
                    AddError(" O Nome Fantasia já foi enviado.");
                    return ValidationResult; 
                }
            }

            fornecedor.AddDomainEvent(new FornecedorUpdatedEvent(fornecedor.Id, fornecedor.NomeFantasia, fornecedor.RazaoSocial, fornecedor.Telefone, fornecedor.Contato, fornecedor.Logradouro, fornecedor.Numero, fornecedor.Complemento, fornecedor.Cep, fornecedor.Ativo));
            _fornecedorRepository.Update(fornecedor);
            return await Commit(_fornecedorRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(RemoveFornecedorCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var fornecedor = await _fornecedorRepository.GetById(message.Id);

            if (fornecedor is null)
            {
                AddError("Esse Nome Fantasia não existe.");
                return ValidationResult;
            }

            fornecedor.AddDomainEvent(new FornecedorRemovedEvent(message.Id));

            _fornecedorRepository.Remove(fornecedor);

            return await Commit(_fornecedorRepository.UnitOfWork);

        }

        public void Dispose()
        {
            _fornecedorRepository.Dispose();
        }
    }

}