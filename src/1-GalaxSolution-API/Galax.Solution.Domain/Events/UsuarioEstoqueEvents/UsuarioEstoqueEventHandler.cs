using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Events.UsuarioEstoqueEvents
{
    public class UsuarioEstoqueEventHandler :
        INotificationHandler<UsuarioEstoqueRegisteredEvent>,
        INotificationHandler<UsuarioEstoqueUpdatedEvent>,
        INotificationHandler<UsuarioEstoqueRemovedEvent>
    {
        public Task Handle(UsuarioEstoqueRegisteredEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(UsuarioEstoqueUpdatedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(UsuarioEstoqueRemovedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
