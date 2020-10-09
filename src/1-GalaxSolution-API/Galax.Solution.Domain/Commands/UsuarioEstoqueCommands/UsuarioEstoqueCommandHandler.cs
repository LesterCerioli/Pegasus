using FluentValidation.Results;
using Galax.Solution.Domain.Entities;
using Galax.Solution.Domain.Events.UsuarioEstoqueEvents;
using Galax.Solution.Domain.Interfaces;
using MediatR;
using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Commands.UsuarioEstoqueCommands
{
    public class UsuarioEstoqueCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewUsuarioEstoqueCommand, ValidationResult>,
        IRequestHandler<UpdateUsuarioEstoqueCommand, ValidationResult>,
        IRequestHandler<RemoveUsuarioEstoqueCommand, ValidationResult>

    {
        private readonly IUsuarioEstoqueRepository _usuarioEstoqueRepository;
        public UsuarioEstoqueCommandHandler(IUsuarioEstoqueRepository usuarioEstoqueRepository)
        {
            _usuarioEstoqueRepository = usuarioEstoqueRepository;
        }

        public async  Task<ValidationResult> Handle(RegisterNewUsuarioEstoqueCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

<<<<<<< HEAD
<<<<<<< HEAD
            var usuarioEstoque = new StockUser(Guid.NewGuid(), message.Login, message.Senha, message.Nome, message.NomeMeio, message.SobreNome, message.Email);
=======
            var usuarioEstoque = new UsuarioEstoque(Guid.NewGuid(), message.Login, message.Senha, message.Nome, message.NomeMeio, message.SobreNome, message.Email, message.Telefone);
>>>>>>> 5ce00386b4f8ce8480d962a96ebe9c67a8d86a72
=======
            var usuarioEstoque = new UsuarioEstoque(Guid.NewGuid(), message.Login, message.Senha, message.Nome, message.NomeMeio, message.SobreNome, message.Email);
>>>>>>> master

            if (await _usuarioEstoqueRepository.GetByEmail(usuarioEstoque.Email) != null)
            {
                AddError(" O E-mail já foi enviado");
                return ValidationResult;

            }
<<<<<<< HEAD
            usuarioEstoque.AddDomainEvent(new UsuarioEstoqueRegisteredEvent(usuarioEstoque.Id, usuarioEstoque.Login, usuarioEstoque.Senha, usuarioEstoque.Nome, usuarioEstoque.NomeMeio, usuarioEstoque.Sobrenome, usuarioEstoque.Email, usuarioEstoque.Telefone));
=======
            usuarioEstoque.AddDomainEvent(new UsuarioEstoqueRegisteredEvent(usuarioEstoque.Id, usuarioEstoque.Login, usuarioEstoque.Senha, usuarioEstoque.Nome, usuarioEstoque.NomeMeio, usuarioEstoque.Sobrenome, usuarioEstoque.Email));
>>>>>>> master

            _usuarioEstoqueRepository.Add(usuarioEstoque);

            return await Commit(_usuarioEstoqueRepository.UnitOfWork);

        }

        public async Task<ValidationResult> Handle(UpdateUsuarioEstoqueCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;
<<<<<<< HEAD
<<<<<<< HEAD
            var usuarioEstoque = new StockUser(message.Id, message.Login, message.Senha, message.Nome, message.NomeMeio, message.SobreNome, message.Email); ;
=======
            var usuarioEstoque = new UsuarioEstoque(message.Id, message.Login, message.Senha, message.Nome, message.NomeMeio, message.SobreNome, message.Email, message.Telefone); ;
>>>>>>> 5ce00386b4f8ce8480d962a96ebe9c67a8d86a72
=======
            var usuarioEstoque = new UsuarioEstoque(message.Id, message.Login, message.Senha, message.Nome, message.NomeMeio, message.SobreNome, message.Email); ;
>>>>>>> master
            var existingUsuarioEstoque = await _usuarioEstoqueRepository.GetByEmail(usuarioEstoque.Email);

            if (existingUsuarioEstoque != null && existingUsuarioEstoque.Id != usuarioEstoque.Id)
            {
                if (!existingUsuarioEstoque.Equals(usuarioEstoque))
                {
                    AddError(" O E-mail já foi enviado");
                    return ValidationResult;
                }
            }

<<<<<<< HEAD
            usuarioEstoque.AddDomainEvent(new UsuarioEstoqueUpdatedEvent(usuarioEstoque.Id, usuarioEstoque.Login, usuarioEstoque.Senha, usuarioEstoque.Nome, usuarioEstoque.NomeMeio, usuarioEstoque.Sobrenome, usuarioEstoque.Email, usuarioEstoque.Telefone));
=======
            usuarioEstoque.AddDomainEvent(new UsuarioEstoqueUpdatedEvent(usuarioEstoque.Id, usuarioEstoque.Login, usuarioEstoque.Senha, usuarioEstoque.Nome, usuarioEstoque.NomeMeio, usuarioEstoque.Sobrenome, usuarioEstoque.Email));
>>>>>>> master

            _usuarioEstoqueRepository.Update(usuarioEstoque);

            return await Commit(_usuarioEstoqueRepository.UnitOfWork);

        }

        public async  Task<ValidationResult> Handle(RemoveUsuarioEstoqueCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var usuarioEstoque = await _usuarioEstoqueRepository.GetById(message.Id);

            if (usuarioEstoque is null)
            {
                AddError("Esse Usuário não existe.");
                return ValidationResult;

            }

            usuarioEstoque.AddDomainEvent(new UsuarioEstoqueRemovedEvent(message.Id));

            _usuarioEstoqueRepository.Remove(usuarioEstoque);

            return await Commit(_usuarioEstoqueRepository.UnitOfWork);

        }

        public void Dispose() 
        {
            _usuarioEstoqueRepository.Dispose();

        }

    }
}
