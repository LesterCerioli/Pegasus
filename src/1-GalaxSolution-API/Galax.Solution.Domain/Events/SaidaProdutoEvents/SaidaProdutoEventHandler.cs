using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galax.Solution.Domain.Events.SaidaProdutoEvents
{
    public class SaidaProdutoEventHandler :
        INotificationHandler<SaidaProdutoRegisteredEvent>,
        INotificationHandler<SaidaProdutoUpdatedEvent>,
        INotificationHandler<SaidaProdutoRemovedEvent>
    {
        public Task Handle(SaidaProdutoRegisteredEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(SaidaProdutoUpdatedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(SaidaProdutoRemovedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
