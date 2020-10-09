using FluentValidation.Results;
using Galax.Solution.Domain.Entities;
using Galax.Solution.Domain.Events.SaidaProdutoEvents;
using Galax.Solution.Domain.Interfaces;
using MediatR;
using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Commands.SaidaProdutoCommands
{
    public class SaidaProdutoCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewSaidaProdutoCommand, ValidationResult>,
        IRequestHandler<UpdateSaidaProdutoCommand, ValidationResult>,
        IRequestHandler<RemoveSaidaProdutoCommand, ValidationResult>

    {

        private readonly ISaidaProdutoRepository _saidaProdutoRepository; 
        public SaidaProdutoCommandHandler(ISaidaProdutoRepository saidaProdutoRepository) 
        {
            _saidaProdutoRepository = saidaProdutoRepository;
        }

        public async Task<ValidationResult> Handle(RegisterNewSaidaProdutoCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

<<<<<<< HEAD
            var saidaProduto = new ProductOutput(Guid.NewGuid(), message.Numero, message.Data, message.Quantidade);
=======
            var saidaProduto = new SaidaProduto(Guid.NewGuid(), message.Numero, message.Data, message.Quantidade);
>>>>>>> master

            if (await _saidaProdutoRepository.GetByNumero(saidaProduto.Numero) != null)
            {
                AddError("O Número da Saída do Produto já foi enviado.");
                return ValidationResult;

            }
            saidaProduto.AddDomainEvent(new SaidaProdutoRegisteredEvent(saidaProduto.Id, message.Numero, saidaProduto.Data, saidaProduto.Quantidade));
            _saidaProdutoRepository.Add(saidaProduto);
            return await Commit(_saidaProdutoRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdateSaidaProdutoCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;
<<<<<<< HEAD
            var saidaProduto = new ProductOutput(message.Id, message.Numero, message.Data, message.Quantidade);
=======
            var saidaProduto = new SaidaProduto(message.Id, message.Numero, message.Data, message.Quantidade);
>>>>>>> master
            var existingSaidaProduto = await _saidaProdutoRepository.GetByNumero(saidaProduto.Numero);

            if (existingSaidaProduto != null && existingSaidaProduto.Id != saidaProduto.Id)
            {
                if (!existingSaidaProduto.Equals(saidaProduto))
                {
                    AddError(" O Número da Saída do Produto já foi enviado.");
                    return ValidationResult;
                }
            }

            saidaProduto.AddDomainEvent(new SaidaProdutoUpdatedEvent(saidaProduto.Id, message.Numero, saidaProduto.Data, saidaProduto.Quantidade));

            _saidaProdutoRepository.Update(saidaProduto);

            return await Commit(_saidaProdutoRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(RemoveSaidaProdutoCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var saidaProduto = await _saidaProdutoRepository.GetById(message.Id);

            if (saidaProduto is null)
            {
                AddError("Esse Número não existe.");
                return ValidationResult;

            }

            saidaProduto.AddDomainEvent(new SaidaProdutoRemovedEvent(message.Id));

            _saidaProdutoRepository.Remove(saidaProduto);

            return await Commit(_saidaProdutoRepository.UnitOfWork);
        }
    }
}
