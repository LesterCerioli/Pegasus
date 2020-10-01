using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Events.GrupoProdutoEvents
{
    public class GrupoProdutoEventHandler :
        INotificationHandler<GrupoProdutoRegisteredEvent>,
        INotificationHandler<GrupoProdutoUpdatedEvent>,
        INotificationHandler<GrupoProdutoRemovedEvent>

    {
        public Task Handle(GrupoProdutoRegisteredEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(GrupoProdutoUpdatedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(GrupoProdutoRemovedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
