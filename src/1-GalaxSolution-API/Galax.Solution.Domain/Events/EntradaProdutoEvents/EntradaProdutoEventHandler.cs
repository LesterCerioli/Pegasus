using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Events.EntradaProdutoEvents
{
    public class EntradaProdutoEventHandler :
        INotificationHandler<EntradaProdutoRegisteredEvent>,
        INotificationHandler<EntradaProdutoUpdatedEvent>,
        INotificationHandler<EntradaProdutoRemovedEvent>

    {
        public Task Handle(EntradaProdutoRegisteredEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(EntradaProdutoUpdatedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(EntradaProdutoRemovedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
