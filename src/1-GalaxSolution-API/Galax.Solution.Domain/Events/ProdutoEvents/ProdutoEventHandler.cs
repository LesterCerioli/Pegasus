using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Events.ProdutoEvents
{
    public class ProdutoEventHandler :
        INotificationHandler<ProdutoRegisteredEvent>,
        INotificationHandler<ProdutoUpdatedEvent>,
        INotificationHandler<ProdutoRemovedEvent>
    {
        public Task Handle(ProdutoRegisteredEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(ProdutoUpdatedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(ProdutoRemovedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
